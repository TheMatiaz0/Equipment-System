using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item")]
public class ItemData : ScriptableObject
{
	[SerializeField]
	private string itemName;

	[SerializeField]
	[TextArea]
	private string itemDescription;


	public string ItemName => itemName;
	public string ItemDescription => itemDescription;
}
