using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{	
	public void ResetScene() 
	{
		Debug.Log ("Reset Scene");
		SceneManager.LoadScene ("Maze");
		// Reset the scene when the user clicks the sign post
	}
}