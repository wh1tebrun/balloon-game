using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControllerScript : MonoBehaviour



{
    public Vector2 speed = new Vector2(50,50);
    
   
    

    void Start()
    {
        
    }
    
        
        
    
   


    
    
    


    

    
    void Update()

    {
       
        
        

        Vector3 movement = new Vector3(5, 0, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);
        
    }
   
   
    
}
