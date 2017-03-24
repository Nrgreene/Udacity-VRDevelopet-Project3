using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	//Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoofPrefab;
	public Door door;


	void Update()
	{
		//Bonus: Key Animation
	}

	public void OnKeyClicked()
	{
		Debug.Log ("OnKeyClicked Called from Key.cs");

		// Instantiate the KeyPoof Prefab where this key is located
		Instantiate (keyPoofPrefab, transform.position, Quaternion.Euler (-90, 0, 0));
		door.Unlock ();

		// Destroy the key
		Destroy (gameObject, 0.5f);

	}
}