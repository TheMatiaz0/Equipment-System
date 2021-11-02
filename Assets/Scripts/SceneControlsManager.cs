using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControlsManager : MonoBehaviour
{
	[SerializeField]
	private GameObject inventoryUI = null;

	protected void Update()
	{
		if (Input.GetKeyDown(KeyCode.Tab))
		{
			inventoryUI.SetActive(!inventoryUI.activeSelf);	
			// Debug.Log($"W twoim ekwipunku znajduj¹ siê {InventoryManager.Current.ToString()}...");
		}
	}
}
