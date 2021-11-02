using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public static class InventoryManager
{
	public const int MaxItemsQuantity = 6;

	public static event Action OnInventoryChange = delegate { };

	public static List<ItemRecord> PickedItems { get; private set; } = new List<ItemRecord>();
	
	public static bool TryAddItem(Item item, int quantity)
	{
		// if itemrecord with this item existed before:
		if (PickedItems.Exists(itemRecord => itemRecord.PickedItem.ItemName == item.ItemName))
		{
			// get this item and add to its record quantity
			ItemRecord itemRecord = PickedItems.First(itemRecord => (itemRecord.PickedItem.GetType() == item.GetType()));
			itemRecord.AddToQuantity(quantity);
		}

		// create entire new item with one quantity:
		else
		{
			if (PickedItems.Count >= MaxItemsQuantity)
			{
				return false;
			}

			PickedItems.Add(new ItemRecord(item, 1));
		}


		OnInventoryChange.Invoke();
		return true;
	}
	
	public static void RemoveItem(Item item, int quantity)
	{
		ItemRecord itemRecord  = PickedItems.First(itemRecord => (itemRecord.PickedItem.ItemName == item.ItemName));
		itemRecord.SubtractFromQuantity(quantity);
		OnInventoryChange.Invoke();
	}


	/*
	public override string ToString()
	{
		StringBuilder stringBld = new StringBuilder();
		string separator = "";
		for (int i = 0; i < PickedItems.Count; i++)
		{
			stringBld.Append(separator);
			stringBld.Append(PickedItems[i].ItemName);
			separator = ",";
		}

		return stringBld.ToString();
	}
	*/
}
