using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VisualItemSlot : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    [SerializeField]
    private GameObject itemImg = null;
	[SerializeField]
	private Text itemQuantityText = null;

	public Item HoldingItem { get; private set; } = null;

	public void Setup(Item item, int itemQuantity)
	{
		HoldingItem = item;
		itemImg.SetActive(item != null);

		if (itemQuantity > 1)
		{
			itemQuantityText.text = $"{itemQuantity.ToString()}x";
		}

		else
		{
			itemQuantityText.text = "";
		}
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		if (HoldingItem == null)
		{
			return;
		}

		InfoBoxSingleton.Current.Setup(HoldingItem.ItemName, HoldingItem.ItemDescription);
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		if (HoldingItem == null)
		{
			return;
		}

		VisualInventorySingleton.Current.SelectSlot(this);
	}
}
