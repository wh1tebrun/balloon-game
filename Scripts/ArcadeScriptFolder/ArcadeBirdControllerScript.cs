using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeBirdControllerScript : MonoBehaviour



{
    public Vector2 speed = new Vector2(50,50);

    
    
   
    

    public void Start()
    {
        
    }
    
        
        
    
   


    
    
    


    

    
    public void FixedUpdate()

    {
        
        

       
        
        

        Vector3 movement = new Vector3(7, 0, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);
        
    }
   
   
    
}
