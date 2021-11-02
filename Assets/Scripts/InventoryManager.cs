using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public static class InventoryManager
{
	public const int MaxItemsQuantity = 6;

	public static List<Item> PickedItems { get; private set; } = new List<Item>();
	
	public static bool TryAddItem(Item item)
	{
		if (PickedItems.Count >= MaxItemsQuantity)
		{
			return false;
		}

		PickedItems.Add(item);
		return true;
	}
	
	public static void RemoveItem(Item item)
	{
		PickedItems.Remove(item);
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
