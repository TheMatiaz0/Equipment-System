using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
	public static InventoryManager Current { get; private set; }

	protected void Awake()
	{
		Current = this;
		PickedItems = new List<Item>();
	}

	public List<Item> PickedItems { get; private set; }
	
	public void AddItem(Item item)
	{
		PickedItems.Add(item);
	}
	
	public void RemoveItem(Item item)
	{
		PickedItems.Remove(item);
	}

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
}
