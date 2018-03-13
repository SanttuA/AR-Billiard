using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class User : MonoBehaviour {

    //public Text testText;   //only for testing

    //how much thrust to apply to the white ball
    public float currentThrust;
    public float highThrust = 1000f;
    public float mediumThrust = 600f;
    public float lowThrust = 300f;

    private void Start()
    {
        currentThrust = highThrust;
    }

    void Update()
    {
        //if user touches white ball, apply thrust to it
        if (Input.touchCount == 1)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                if (Physics.Raycast(ray, out hit) && (hit.collider.tag == "Ball"))
                {
                    hit.transform.GetComponent<Rigidbody>().AddForce(transform.forward * currentThrust);
                }
            }
        }
    }

    //set current thrust to be high
    public void UseHighThrust(bool isUsed)
    {
        if(isUsed) { currentThrust = highThrust; }
    }

    //set current thrust to be medium
    public void UseMediumThrust(bool isUsed)
    {
        if (isUsed) { currentThrust = mediumThrust; }
    }

    //set current thrust to be low
    public void UseLowThrust(bool isUsed)
    {
        if (isUsed) { currentThrust = lowThrust; }
    }
}
