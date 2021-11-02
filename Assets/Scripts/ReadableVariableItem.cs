using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadableVariableItem : VariableItem<string>
{
	public ReadableVariableItem(string itemName, string itemDescription, string text) : 
		base(itemName: itemName, itemDescription: itemDescription, itemVariable: text)
	{
	}

	public override void Usage()
	{
		Debug.Log($"Przeczytano przedmiot o nazwie {ItemName} (oto jego zawartoœæ: {ItemVariable})");
		InventoryManager.RemoveItem(this, 1);
	}
}
