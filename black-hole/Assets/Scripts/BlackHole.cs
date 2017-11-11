using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour {

        public double mass;

        const double G = 6.674e-11;
        const int c = 299792458;

	// Use this for initialization
	void Start () {
	    Debug.Log(determine_radius(mass));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

        double determine_radius (double mass_value) {
           return( (2 * mass_value * G) / Mathf.Pow(c, 2) ); 
        }
}
