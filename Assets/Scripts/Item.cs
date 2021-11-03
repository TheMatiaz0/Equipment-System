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
		Debug.Log($"Wyrzucono przedmiot o nazwie {ItemName}");
		InventoryManager.RemoveItem(this, 1);
	}

	public abstract void Usage();
}
