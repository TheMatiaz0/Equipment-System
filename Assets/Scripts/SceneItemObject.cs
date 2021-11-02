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
		Debug.Log($"Podniesiono przedmiot o nazwie {itemData.ItemName}!");
		InventoryManager.Current.AddItem(itemData.GetItem());
		Destroy(this.gameObject);
	}
}
