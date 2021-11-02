using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextMenuSingleton : MonoBehaviour
{
	public static ContextMenuSingleton Current { get; private set; } = null;

	protected void Awake()
	{
		Current = this;
	}
}
