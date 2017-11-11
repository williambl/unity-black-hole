using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour {

        public double mass;
        public Transform hole;

        const double G = 6.674e-11;
        const int c = 299792458;

        double radius;

	// Use this for initialization
	void Start () {
            radius = determine_radius(mass);
	    Debug.Log(radius);
            hole.localScale = new Vector3((float)(2f*radius), (float)(2f*radius), (float)(2f*radius));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

        double determine_radius (double mass_value) {
           return( (2 * mass_value * G) / Mathf.Pow(c, 2) ); 
        }
}
