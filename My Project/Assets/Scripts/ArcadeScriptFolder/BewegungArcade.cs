using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BewegungArcade: MonoBehaviour



{
    public GameObject ArcadeWolke;
    
    private float WolkeArcadeSpeed = -5f;
    private float WolkeAracdeSpeedCounter = 0f;


    
    
    
    
    

    
    void Start()
    {
        
    }

    
    
   
    

   
        
        
    
   


    
    
    


    

    
    void Update()

    {
       
       
        
        
       
       
       
        
        
       
        
        

        

       

/*
        if(WolkeAracdeSpeedCounter >= 5)
        {
            WolkeArcadeSpeed = -50.5f;

        }
        if(WolkeAracdeSpeedCounter >= 60)
        {
            WolkeArcadeSpeed = -6f;
        }
        if(WolkeAracdeSpeedCounter >= 90)
        {
            WolkeArcadeSpeed = -6.5f;
        }
        if(WolkeAracdeSpeedCounter >= 120)
        {
            WolkeArcadeSpeed = -7f;
        }
        if(WolkeAracdeSpeedCounter >= 150)
        {
            WolkeArcadeSpeed = -7.5f;
        }
        if(WolkeAracdeSpeedCounter >= 180)
        {
            WolkeArcadeSpeed = -8f;
        }
        if(WolkeAracdeSpeedCounter >= 210)
        {
            WolkeArcadeSpeed = -8.5f;
        }
        if(WolkeAracdeSpeedCounter >= 240)
        {
            WolkeArcadeSpeed = -9f;
        }
        if(WolkeAracdeSpeedCounter >= 270)
        {
            WolkeArcadeSpeed = -9.5f;
        }
        if(WolkeAracdeSpeedCounter >= 300)
        {
            WolkeArcadeSpeed = -10f;
        }
        if(WolkeAracdeSpeedCounter >= 330)
        {
            WolkeArcadeSpeed = -10.5f;
        }
        if(WolkeAracdeSpeedCounter >= 360)
        {
            WolkeArcadeSpeed = -11f;
        }
        if(WolkeAracdeSpeedCounter >= 390)
        {
            WolkeArcadeSpeed = -11.5f;
        }
        if(WolkeAracdeSpeedCounter >= 420)
        {
            WolkeArcadeSpeed = -12f;
        }
        if(WolkeAracdeSpeedCounter >= 450)
        {
            WolkeArcadeSpeed = -12.5f;
        }
        if(WolkeAracdeSpeedCounter >= 480)
        {
            WolkeArcadeSpeed = -13f;
        }
        if(WolkeAracdeSpeedCounter >= 510)
        {
            WolkeArcadeSpeed = -13.5f;
        }
        if(WolkeAracdeSpeedCounter >= 540)
        {
            WolkeArcadeSpeed = -14f;
        }
        */
        
        Vector3 movement = new Vector3(0, WolkeArcadeSpeed, 0);
        movement *= Time.deltaTime;

        transform.Translate(movement);
        
    }
    void OnCollisionEnter2D(Collision2D temas)
    {
        
    }
   
    
}
