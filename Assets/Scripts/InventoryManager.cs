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
	}

	private List<Item> pickedItems = new List<Item>();
	public IReadOnlyList<Item> PickedItems => pickedItems;
	
	public void AddItem(Item item)
	{
		pickedItems.Add(item);
	}
	
	public void RemoveItem(Item item)
	{
		pickedItems.Remove(item);
	}

	public override string ToString()
	{
		StringBuilder stringBld = new StringBuilder();
		string separator = "";
		for (int i = 0; i < pickedItems.Count; i++)
		{
			stringBld.Append(separator);
			stringBld.Append(pickedItems[i].ItemName);
			separator = ",";
		}

		return stringBld.ToString();
	}
}
