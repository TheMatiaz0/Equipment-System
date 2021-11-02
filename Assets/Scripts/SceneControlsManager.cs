using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControlsManager : MonoBehaviour
{
	protected void Update()
	{
		if (Input.GetKeyDown(KeyCode.Tab))
		{
			Debug.Log($"W twoim ekwipunku znajduj� si� {InventoryManager.Current.ToString()}...");
		}

		if (Input.GetKeyDown(KeyCode.G))
		{
			InventoryManager.Current.PickedItems[0].Usage();
		}
	}
}
