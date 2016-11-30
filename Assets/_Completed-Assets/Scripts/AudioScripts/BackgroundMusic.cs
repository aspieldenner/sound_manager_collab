//Aaron Spieldenner, Sergio Ramos, Kristian Veech
//LMSC-281
//Sound Manager Collab.
using UnityEngine;
using System.Collections;

public class BackgroundMusic : MonoBehaviour {

	SoundManager mySound;


	// Use this for initialization
	void Start () {

		//do not need these because the function is static
		//GameObject myNewSounds = GameObject.Find ("AudioObject"); //finds the GameObject called AudioObject, which has the background music attached to it.
		//mySound = myNewSounds.GetComponent<SoundManager> (); 

		SoundManager.PlayObjectSound (this.gameObject); //calls the static function PlayObjectSound from the SoundManager.
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}
}
