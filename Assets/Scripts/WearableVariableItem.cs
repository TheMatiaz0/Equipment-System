using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WearableVariableItem : VariableItem<float>
{
	public WearableVariableItem(string itemName, string itemDescription, float itemDmg) :
	base(itemName: itemName, itemDescription: itemDescription, itemVariable: itemDmg)
	{
	}

	public override void Usage()
	{
		Debug.Log($"Wyposa¿ono w ubranie o nazwie {ItemName} (statystyki {ItemVariable} ochrony przed DMG)");
		InventoryManager.RemoveItem(this, 1);
	}
}
