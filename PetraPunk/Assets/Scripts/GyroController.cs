﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GyroController : MonoBehaviour
{

    private float gyroInput;
    public float speedMultiplier =10;
    public float maxVelocity;

    public enum control { New, Old };

    public control controlType;


    public FloatVariable steeringOutput;

    //public Text tex;


    // float timer = 0;

    // float rotationThreshHold = 0.2f;
    float currentRot = 0;



    void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;
        Input.gyro.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        float rotRate = 0;

        if (controlType == control.Old)
        {
            rotRate = Input.gyro.rotationRate.y;
        }
        else
        {
            rotRate = Input.gyro.rotationRate.z;
        }


        currentRot += rotRate * Time.deltaTime;


        gyroInput = currentRot * -speedMultiplier;
        



        steeringOutput.Value = gyroInput;
       
        
        // Dampening
        //transform.Rotate(Vector3.up * Mathf.Min(steeringInput * 100, maxVelocity) * Time.deltaTime);
        // transform.Translate(Vector3.left * steeringInput * 10 * Time.deltaTime);

        // Old Threshold
        //if (Mathf.Abs(currentRot) > rotationThreshHold)
        //{
        //    //timer = 0;
        //    if (currentRot < 0)
        //    {
        //        steeringInput = -1;
        //    }
        //    else
        //    {

        //        steeringInput = 1;
        //    }
        //}
        //else
        //{

        //    steeringInput = 0;

        //}


    }
}
