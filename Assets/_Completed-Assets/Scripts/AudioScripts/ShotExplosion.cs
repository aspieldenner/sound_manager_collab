//Aaron Spieldenner, Sergio Ramos, Kristian Veech
//LMSC-281
//Sound Manager Collab.
using UnityEngine;
using System.Collections;

public class ShotExplosion : MonoBehaviour {

	SoundManager mySound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		SoundManager.PlayExplosion (this.gameObject); //calls Kristian Veech's function
	
	}
}
