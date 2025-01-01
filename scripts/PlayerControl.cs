using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Camera maincamera,seconcam;
    public string changecam;
    public int ID, speed=10;
    public float angle=60;
    private float horizentalInput,forwardInput;
    private float factor,factor2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.deltaTime;
        //get input
        horizentalInput = Input.GetAxis("Horizontal"+ID);
        forwardInput = Input.GetAxis("Vertical"+ID);

        //move viecule
        factor = angle * time * horizentalInput;
        factor2 = speed * time * forwardInput;
        transform.Translate(Vector3.forward*factor2);
        //transform.Translate(Vector3.right*turnSpeed*time);
        transform.Rotate(Vector3.up,factor);

        //change the camera
        if (Input.GetKeyDown(changecam))
        {
            maincamera.enabled = !maincamera.enabled;
            seconcam.enabled = !seconcam.enabled;
        }
    }
}
