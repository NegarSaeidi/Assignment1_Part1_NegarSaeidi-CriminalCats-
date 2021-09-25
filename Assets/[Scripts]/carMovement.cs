/*
 *                    CRIMINAL CATS
 *                    Author: Negar Saeidi
 *                    Student number : 101261396
 *                    Date last modified: 9/25/2021
 *                    Rivision history: 1st version : simple movement added for testing
 *                                      2nd version : changing the input type to touch
 *                                      
 *                    Name of this Script: carMovement: control the simple movement of car by touch input
 *                    
 *                    
 */                   
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class carMovement : MonoBehaviour
{
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); 

            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            {
               
                Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));
               
                transform.position = Vector3.Lerp(transform.position, touchedPos, Time.deltaTime);
            }
        }
    }
}
