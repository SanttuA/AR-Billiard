using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    //if a colored ball enters this trigger collider, destroy the colored ball
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ColorBall")
        {
            Destroy(other.gameObject);
        }
    }
}
