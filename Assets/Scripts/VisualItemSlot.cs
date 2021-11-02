using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VisualItemSlot : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    [SerializeField]
    private GameObject itemImg = null;

	public Item HoldingItem { get; private set; } = null;

	public void Setup(Item item)
	{
		HoldingItem = item;
		itemImg.SetActive(item != null);
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
