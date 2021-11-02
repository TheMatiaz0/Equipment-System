using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisualInventorySingleton : MonoBehaviour
{
	public static VisualInventorySingleton Current { get; private set; } = null;

	[SerializeField]
	private VisualItemSlot itemSlotPrefab = null;

	[SerializeField]
	private Transform slotParent = null;

	private List<VisualItemSlot> visualSlots = new List<VisualItemSlot>();

	private VisualItemSlot chosenSlot = null;

	[SerializeField]
	private Button usageBtn = null;

	[SerializeField]
	private Button throwBtn = null;

	protected void Awake()
	{
		Current = this;
		InventoryManager.OnInventoryChange += InventoryManager_OnInventoryChange;
		for (int i = 0; i < InventoryManager.MaxItemsQuantity; i++)
		{
			VisualItemSlot visualSlot = Instantiate(itemSlotPrefab, slotParent);
			visualSlots.Add(visualSlot);
		}
	}

	protected void OnDestroy()
	{
		InventoryManager.OnInventoryChange -= InventoryManager_OnInventoryChange;
	}

	private void InventoryManager_OnInventoryChange()
	{
		Refresh();
	}

	protected void OnEnable()
	{
		Refresh();
	}

	public void Refresh() 
	{
		SelectSlot(null);
		InfoBoxSingleton.Current.Setup(null, null);
		for (int i = 0; i < InventoryManager.MaxItemsQuantity; i++)
		{
			Item inventoryItem;
			if (i >= InventoryManager.PickedItems.Count)
			{
				inventoryItem = null;
			}
			else
			{
				inventoryItem = InventoryManager.PickedItems[i];
			}

			VisualItemSlot visualSlot = visualSlots[i];

			visualSlot.Setup(inventoryItem);
		}
	}

	public void SelectSlot(VisualItemSlot slot)
	{
		chosenSlot = slot;
		if (chosenSlot != null)
		{
			usageBtn.onClick.AddListener(() => chosenSlot?.HoldingItem?.Usage());
			throwBtn.onClick.AddListener(() => chosenSlot?.HoldingItem?.Throw());
		}

		usageBtn.gameObject.SetActive(chosenSlot != null);
		throwBtn.gameObject.SetActive(chosenSlot != null);
	}
}
