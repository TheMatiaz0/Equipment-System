using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoBoxObject : MonoBehaviour
{
	public static InfoBoxObject Current { get; private set; } = null;

	protected void Awake()
	{
		Current = this;
	}

	[SerializeField]
	private Text itemName = null;

	[SerializeField]
	private Text itemDescription = null;

	public void Setup(string itemName, string itemDescription)
	{
		this.itemName.text = itemName;
		this.itemDescription.text = itemDescription;
	}
}
