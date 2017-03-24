using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	bool locked = true;
	bool closed = true;
	public AudioClip doorOpened;
	public AudioClip doorLock;
	public AudioSource doorAudioSource;

	void Update() {
		if(!locked && !closed)
		{
			transform.Translate(0f, 2.5f * Time.deltaTime, 0f, Space.World);
		}

	}

	public void Unlock()
	{
		Debug.Log (locked);
		locked = false;	
		Debug.Log (locked);

	}

	public void OpenDoor()
	{
		if (locked == false) {
			Debug.Log (closed);
			closed = false;
			Debug.Log (closed);
			doorAudioSource.clip = doorOpened;
			doorAudioSource.Play();
		} else {
			Debug.Log (locked);
			doorAudioSource.clip = doorLock;
			doorAudioSource.Play();
		}
	
	}


}
