using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSpecificData : ISpecificData
{
	[SerializeField]
	[TextArea]
	private string variable = null;

	public object GetSpecificVariable()
	{
		return variable;
	}
}
