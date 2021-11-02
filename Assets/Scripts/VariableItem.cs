using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VariableItem<T> : Item
{
	public T ItemVariable { get; protected set; }
	public VariableItem(string itemName, string itemDescription, T itemVariable) : base(itemName: itemName, itemDescription: itemDescription)
	{
		ItemVariable = itemVariable;
	}

	public override abstract void Usage();
}
