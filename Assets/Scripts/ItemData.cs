using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
	Drinkable,
	Weapon,
	Wearable,
	Readable
}

[CreateAssetMenu(menuName = "ItemData")]
public class ItemData : ScriptableObject
{
	[SerializeField]
	private string itemName;

	[SerializeField]
	[TextArea]
	private string itemDescription;

	[SerializeField]
	private ItemType itemType;


	public string ItemName => itemName;
	public string ItemDescription => itemDescription;


	public Item GetItem()
	{
		switch (itemType)
		{
			case ItemType.Drinkable:
				return new DrinkableVariableItem(itemName, itemDescription, UnityEngine.Random.Range(5, 25));

			case ItemType.Readable:
				throw new NotImplementedException();

			case ItemType.Weapon:
				return new WeaponVariableItem(itemName, itemDescription, 3);

			case ItemType.Wearable:
				throw new NotImplementedException();
		}

		return null;
	}
}
