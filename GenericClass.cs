// Example of a Generic class usage

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {

public GameObject GameManager2;

void Awake () 
{
	KeyValuePair<int, string> course = new KeyValuePair<int, string> (1, "Devslopes");
	course.Print();

	KeyValuePair<string, string> lesson = new KeyValuePair<string, string> ("Number 1 Lesson", "Learning about generics");
	lesson.Print();
}

public class KeyValuePair<Tkey, Tvalue>
{
	public Tkey key;
	public Tvalue value;

	public KeyValuePair(Tkey _key, Tvalue _value)
	{
		key = _key;
		value = _value;
	}

	public void Print()
	{
		Debug.Log("Key: " + key.ToString());
		Debug.Log("Value: " + value.ToString());
	}
}
