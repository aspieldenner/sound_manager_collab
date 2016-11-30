//Aaron Spieldenner, Sergio Ramos, Kristian Veech
//LMSC-281
//Sound Manager Collab.
using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Aaron Spieldenner's function; borrowed from J.Cowen's SoundManager script
	//this function is static, meaning it cannot exist anywhere else except in this script
	public static void PlayObjectSound (GameObject thisObject) {

		//if the audio source is not playing, play it
		if (!thisObject.GetComponent<AudioSource>().isPlaying){ 
			thisObject.GetComponent<AudioSource>().Play();
		}
	}

	//Made by Kristian Veech
	public static void PlayExplosion (GameObject thisObject) {

		if (Input.GetButtonDown ("Fire1")) {
			thisObject.GetComponent<AudioSource> ().Play ();
			
		}
	}

	//Sergio's idea.  Figured this out with Jeanine's help.  
	public static void PlayShellExplosion (AudioSource audioToPlay) {
		audioToPlay.Play ();
	}
}


