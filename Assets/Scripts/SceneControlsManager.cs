using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControlsManager : MonoBehaviour
{
	[SerializeField]
	private GameObject inventoryUI = null;

	public bool IsInventoryOpen { get; private set; }

	public static SceneControlsManager Current { get; private set; } = null;

	protected void Awake()
	{
		Current = this;
	}

	protected void Update()
	{
		if (Input.GetKeyDown(KeyCode.Tab))
		{
			IsInventoryOpen = !IsInventoryOpen;
			inventoryUI.SetActive(IsInventoryOpen);	
			// Debug.Log($"W twoim ekwipunku znajduj¹ siê {InventoryManager.Current.ToString()}...");
		}
	}
}
