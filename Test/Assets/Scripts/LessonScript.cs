using UnityEngine;
using System.Collections;

public class LessonScript : MonoBehaviour 
{
	
	// Use this for initialization
	void Start () 
	{
		int num = 5;

		print ("This number is " + (num % 2 == 0 ? "even" : "odd"));
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
