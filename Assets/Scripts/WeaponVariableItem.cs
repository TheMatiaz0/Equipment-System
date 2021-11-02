using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponVariableItem : VariableItem<float>
{
	public WeaponVariableItem(string itemName, string itemDescription, float itemDmg) : base(itemName: itemName, itemDescription: itemDescription, itemVariable: itemDmg)
	{
	}

	public override void Usage()
	{
		Debug.Log($"Wyposa¿ono w broñ o nazwie {ItemName} (statystyki {ItemVariable} DMG)");
		InventoryManager.RemoveItem(this, 1);
	}
}
