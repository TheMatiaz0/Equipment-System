using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item
{
	public string ItemName { get; } 
	public string ItemDescription { get; }
	public Item(string itemName, string itemDescription)
	{
		ItemName = itemName;
		ItemDescription = itemDescription;
	}

	public void Throw()
	{
		InventoryManager.Current.RemoveItem(this);
	}

	public abstract void Usage();
}
