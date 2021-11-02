using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
	None,
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
	public ItemType ItemType => itemType;
}
