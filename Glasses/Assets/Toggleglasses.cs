using UnityEngine;
using System.Collections;

public class Toggleglasses : MonoBehaviour 
{
	public bool glassesVisible;

	// Use this for initialization
	void Start () 
	{
		glassesVisible = true;
		}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyUp("1") & glassesVisible == false)
		{
			glassesVisible = true;
		}
		if(Input.GetKeyUp("1") & glassesVisible == true)
		{
			glassesVisible = false;
		}
		if (glassesVisible == true)
		{
			gameObject.GetComponent<MeshRenderer>().enabled=true;
		}
		else
		{
			gameObject.GetComponent<MeshRenderer>().enabled=false;
		}
	}
}
