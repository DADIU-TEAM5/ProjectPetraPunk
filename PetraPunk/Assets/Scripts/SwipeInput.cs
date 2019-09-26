﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeInput : MonoBehaviour
{
    public PlayerController playerCOntroller;

    Touch currentTouch;
    //public Text debby;

    Vector2 startPos;
    Vector2 endPos;

    float direction;


    bool CurrentlyTOuching;
    

    // Start is called before the first frame update
    void Start()
    {
       // debby.text = Input.touchCount + "";
    }

    // Update is called once per frame
    void Update()
    {


        

        if(Input.touchCount > 0)
        {
            
            currentTouch = Input.GetTouch(0);

            if(startPos == Vector2.zero)
            startPos = currentTouch.position;

            endPos = currentTouch.position;

            //debby.text = startPos.x + " - " + endPos.x;
            direction = startPos.x - endPos.x;

        }
        else
        {
            if (direction < 0)
                direction = 1;
            else if (direction > 0)
                direction = -1;

            if (startPos != Vector2.zero)
                playerCOntroller.Dash(direction);

            startPos = Vector2.zero;
           // debby.text = direction + "";
        }
    }

   
}