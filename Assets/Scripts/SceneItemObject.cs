
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneItemObject : MonoBehaviour
{
	[SerializeField]
	private ItemData itemData = null;


	// needs improvement with UnityEditor:
	[SerializeField]
	[TextArea]
	private string itemText = null;

	[SerializeField]
	private Vector2 itemNumericRange;


	private void OnMouseDown()
	{
		if (InventoryManager.TryAddItem(GetItem(), 1))
		{
			Debug.Log($"Podniesiono przedmiot o nazwie {itemData.ItemName}!");
			Destroy(this.gameObject);
		}

		else
		{
			Debug.Log($"Za du¿o przedmiotów w ekwipunku!");

		}

	}

	public Item GetItem()
	{
		switch (itemData.ItemType)
		{
			case ItemType.Drinkable:
				return new DrinkableVariableItem(itemData.ItemName, itemData.ItemDescription, (int)Random.Range(itemNumericRange.x, itemNumericRange.y));

			case ItemType.Readable:
				return new ReadableVariableItem(itemData.ItemName, itemData.ItemDescription, itemText);

			case ItemType.Weapon:
				return new WeaponVariableItem(itemData.ItemName, itemData.ItemDescription, (int)Random.Range(itemNumericRange.x, itemNumericRange.y));

			case ItemType.Wearable:
				return new WearableVariableItem(itemData.ItemName, itemData.ItemDescription, (int)Random.Range(itemNumericRange.x, itemNumericRange.y));
		}

		return null;
	}
}
