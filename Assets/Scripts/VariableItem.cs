using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VariableItem : Item
{
	public object ItemVariable { get; protected set; }
	public VariableItem(string itemName, string itemDescription, object itemVariable) : base(itemName: itemName, itemDescription: itemDescription)
	{
		ItemVariable = itemVariable;
	}

	public override abstract void Usage();
}
