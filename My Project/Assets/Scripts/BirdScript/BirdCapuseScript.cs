using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCapuseScript : MonoBehaviour
{
    

  

         void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.tag == "obstacle")
        {
            
            
            // Destroy(gameObject);
            // Destroy(transform.parent.gameObject);
        }

          if (collision.collider.tag == "Balloon")
        {
            
            
            Destroy(gameObject);
            Destroy(transform.parent.gameObject);
        }
        
    }
}