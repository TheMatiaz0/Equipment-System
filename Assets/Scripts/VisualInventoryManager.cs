using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualInventoryManager : MonoBehaviour
{
	[SerializeField]
	private VisualItemSlot itemSlotPrefab = null;

	[SerializeField]
	private Transform slotParent = null;

	private List<VisualItemSlot> allInventorySlots = new List<VisualItemSlot>();



	protected void Awake()
	{
		for (int i = 0; i < InventoryManager.MaxItemsQuantity; i++)
		{
			allInventorySlots.Add(Instantiate(itemSlotPrefab, slotParent));
		}
	}

	protected void OnEnable()
	{
		Refresh();
	}

	public void Refresh() 
	{
		for (int i = 0; i < InventoryManager.PickedItems.Count; i++)
		{
			Item inventoryItem = InventoryManager.PickedItems[i];
			VisualItemSlot visualSlot = allInventorySlots[i];

			visualSlot.Setup(inventoryItem);
		}
	}
}
