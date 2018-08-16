using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialCollection : MonoBehaviour {

    public int health;

	// Use this for initialization
	void Start () {
		// Set the health of the asteroid, later it will be dependant on the size of the asteroid
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		// On trigger of bullet, reduce health and size of asteroid
        // Release smaller circles of the asteroid for player to pickup 
        // On depletion of health, release a larger amount of smaller circles
	}
}
