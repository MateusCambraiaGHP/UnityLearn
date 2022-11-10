using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isVehicleMovement { get { return verticalInput >= 0; } }
    private float speedVehicle;
    private float turnSpeed;
    private float horizontalInput;
    private float verticalInput;
    
    void Start()
    {
        
    }

    // A cada frame
    void Update()
    {
        var translationVehicleRight = Vector3.up * turnSpeed * Time.deltaTime * horizontalInput;
        var translationVehicleForward = Vector3.forward * Time.deltaTime * speedVehicle * verticalInput;
        //capturando inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(translationVehicleForward);
        if (isVehicleMovement)
        {
            transform.Rotate(translationVehicleRight);
        }
        //atualizando velocidade do veiculo
        UpdateSpeedVehicle();
    }

    private void UpdateSpeedVehicle() 
    {
        if (isVehicleMovement)
        {
            speedVehicle += 0.1f;
            turnSpeed += 0.1f;
        }
    }
}