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
	}
}
