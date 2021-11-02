using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumericRangeSpecificData : ISpecificData
{
	[SerializeField]
	private Vector2 variable;

	public object GetSpecificVariable()
	{
		return variable;
	}
}
