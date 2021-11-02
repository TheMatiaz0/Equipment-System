using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VisualItemSlot : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField]
    private GameObject itemImg = null;

	private Item holdingItem = null;

	public void Setup(Item item)
	{
		holdingItem = item;
		itemImg.SetActive(item != null);
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		if (holdingItem == null)
		{
			return;
		}

		InfoBoxObject.Current.Setup(holdingItem.ItemName, holdingItem.ItemDescription);
	}
}
