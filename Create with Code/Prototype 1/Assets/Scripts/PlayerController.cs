using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedVehicle = 5.0f;
    public float turnSpeed;
    public float horizontalInput;
    
    void Start()
    {
        
    }

    // A cada frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        var translationVehicleForward = Vector3.forward * Time.deltaTime * speedVehicle;
        var translationVehicleRight = Vector3.right * Time.deltaTime * turnSpeed * horizontalInput;
        transform.Translate(translationVehicleForward);
        transform.Translate(translationVehicleRight);
    }
}