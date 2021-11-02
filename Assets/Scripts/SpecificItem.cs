using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SpecificItem
{
	[SerializeField]
	private ItemData type;
	[SerializeReference]
	private ISpecificData specific;

	public ItemData Type => type;
	public ISpecificData Specific => specific;

	public void RefreshType()
	{
		specific = CreateSpecificType(this.type.ItemType);
	}

	public ISpecificData CreateSpecificType(ItemType itemType)
	{
		return itemType switch
		{
			ItemType.Drinkable => new NumericRangeSpecificData(),
			ItemType.Readable => new TextSpecificData(),
			ItemType.Wearable => new NumericRangeSpecificData(),
			ItemType.Weapon => new NumericRangeSpecificData(),
			_ => null
		};
	}
}
