using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBall : MonoBehaviour {

    public Transform resetPosition; //set in editor

	// Use this for initialization
	void Start () {
		
	}
	
    //set the ball's position to be reset position
    private void ResetPosition()
    {
        transform.position = resetPosition.position;
    }

    //when the ball enters reset zone, reset the balls position
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ResetZone")
        {
            ResetPosition();
        }
    }
}
