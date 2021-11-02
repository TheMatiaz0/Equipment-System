using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRecord
{
	public Item PickedItem { get; private set; }
	public int Quantity { get; private set; }

	public ItemRecord(Item item, int quantity)
	{
		PickedItem = item;
		Quantity = quantity;
	}

	public void AddToQuantity(int amount)
	{
		Quantity += amount;
	}

	public void SubtractFromQuantity(int amount)
	{
		Quantity -= amount;
		
		if (Quantity < 1)
		{
			InventoryManager.PickedItems.Remove(this);
		}
	}

}
