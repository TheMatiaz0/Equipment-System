using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneItem : MonoBehaviour
{
	[SerializeField]
	private ItemData itemData = null;

	private void OnMouseDown()
	{
		Debug.Log($"Podnios³eœ item o nazwie {itemData.ItemName}!");
		InventoryManager.Current.AddItem(new Item(itemData.ItemName, itemData.ItemDescription));
		Destroy(this.gameObject);
	}
}
