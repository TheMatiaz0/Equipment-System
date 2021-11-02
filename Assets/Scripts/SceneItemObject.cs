
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneItemObject : MonoBehaviour
{
	[SerializeField]
	private SpecificItem itemData = null;


	private void OnMouseDown()
	{
		if (SceneControlsManager.Current.IsInventoryOpen)
		{
			return;
		}

		if (InventoryManager.TryAddItem(GetItem(), 1))
		{
			Debug.Log($"Podniesiono przedmiot o nazwie {itemData.Type.ItemName}!");
			Destroy(this.gameObject);
		}

		else
		{
			Debug.Log($"Za du¿o przedmiotów w ekwipunku!");

		}

	}

	public Item GetItem()
	{


		switch (itemData.Type.ItemType)
		{
			case ItemType.Drinkable:
				{
					var item = (Vector2)((NumericRangeSpecificData)(itemData.Specific)).GetSpecificVariable();
					return new DrinkableVariableItem(itemData.Type.ItemName, itemData.Type.ItemDescription, (int)Random.Range(item.x, item.y + 1));
				}


			case ItemType.Readable:
				{
					var item = (string)((TextSpecificData)(itemData.Specific)).GetSpecificVariable();
					return new ReadableVariableItem(itemData.Type.ItemName, itemData.Type.ItemDescription, item);
				}


			case ItemType.Weapon:
				{
					var item  = (Vector2)((NumericRangeSpecificData)(itemData.Specific)).GetSpecificVariable();
					return new WeaponVariableItem(itemData.Type.ItemName, itemData.Type.ItemDescription, (int)Random.Range(item.x, item.y + 1));
				}


			case ItemType.Wearable:
				{
					var item  = (Vector2)((NumericRangeSpecificData)(itemData.Specific)).GetSpecificVariable();
					return new WearableVariableItem(itemData.Type.ItemName, itemData.Type.ItemDescription, (int)Random.Range(item.x, item.y + 1));
				}
		}

		return null;
	}
}
