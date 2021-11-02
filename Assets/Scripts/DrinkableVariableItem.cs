using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkableVariableItem : VariableItem<int>
{
	public DrinkableVariableItem(string itemName, string itemDescription, int itemHpRegain) 
		: base(itemName: itemName, itemDescription: itemDescription, itemVariable: itemHpRegain)
	{
	}

	public override void Usage()
	{
		Debug.Log($"Wypito przedmiot o nazwie {ItemName} (dodano {ItemVariable} HP)");
		InventoryManager.RemoveItem(this, 1);
	}
}
