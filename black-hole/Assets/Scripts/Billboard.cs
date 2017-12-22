using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour {

    public Transform cam;

    void Update () {
        transform.LookAt(transform.position+cam.forward, cam.up);
    }
}
