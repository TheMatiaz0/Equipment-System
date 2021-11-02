using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneItemObject : MonoBehaviour
{
	[SerializeField]
	private ItemData itemData = null;

	private void OnMouseDown()
	{
		if (InventoryManager.TryAddItem(itemData.GetItem()))
		{
			Debug.Log($"Podniesiono przedmiot o nazwie {itemData.ItemName}!");
			Destroy(this.gameObject);
		}

		else
		{
			Debug.Log($"Za du¿o przedmiotów w ekwipunku!");
		}

	}
}
