using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(SpecificItem))]
public class SpecificItemDrawer : PropertyDrawer
{
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{
        EditorGUI.BeginProperty(position, label, property);
		Rect single = position;
		single.height = EditorGUIUtility.singleLineHeight;
		EditorGUI.PropertyField(single, property.FindPropertyRelative("type"), true);
		single.y += EditorGUIUtility.singleLineHeight;

        EditorGUI.PropertyField(single, property.FindPropertyRelative("specific"), true);

        single.y += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("specific"), true);

        if (GUI.Button(single, "Populate"))
		{
            (fieldInfo.GetValue(GetParent(property)) as SpecificItem).RefreshType();

		}


        EditorGUI.EndProperty();
	}

	public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
	{
        
        return EditorGUIUtility.singleLineHeight * 2 + EditorGUI.GetPropertyHeight(property.FindPropertyRelative("specific"), true);
	}


	// https://answers.unity.com/questions/425012/get-the-instance-the-serializedproperty-belongs-to.html
	public object GetParent(SerializedProperty prop)
    {
        var path = prop.propertyPath.Replace(".Array.data[", "[");
        object obj = prop.serializedObject.targetObject;
        var elements = path.Split('.');
        foreach (var element in elements.Take(elements.Length - 1))
        {
            if (element.Contains("["))
            {
                var elementName = element.Substring(0, element.IndexOf("["));
                var index = Convert.ToInt32(element.Substring(element.IndexOf("[")).Replace("[", "").Replace("]", ""));
                obj = GetValue(obj, elementName, index);
            }
            else
            {
                obj = GetValue(obj, element);
            }
        }
        return obj;
    }

    public object GetValue(object source, string name)
    {
        if (source == null)
            return null;
        var type = source.GetType();
        var f = type.GetField(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
        if (f == null)
        {
            var p = type.GetProperty(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
            if (p == null)
                return null;
            return p.GetValue(source, null);
        }
        return f.GetValue(source);
    }

    public object GetValue(object source, string name, int index)
    {
        var enumerable = GetValue(source, name) as IEnumerable;
        var enm = enumerable.GetEnumerator();
        while (index-- >= 0)
            enm.MoveNext();
        return enm.Current;
    }
}
