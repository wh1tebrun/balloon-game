using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStopping : MonoBehaviour
{
    public GameObject Background;
    public GameObject Background2;
    Animator playerAnimator;
    bool BalloonDestroyed = false;

  
    void Start()
        {
            playerAnimator = GetComponent<Animator>();
        }


    void DestroyBalloon()
    {
        Destroy(gameObject);
        Background.SetActive(true);
        Time.timeScale = 0f;
    }




    void OnCollisionEnter2D(Collision2D collision)
    {


        
        
        if (collision.collider.tag == "obstacle")
        {
            
            
            playerAnimator.SetBool("Die",true);
            Invoke("DestroyBalloon",0.15f);
            
            
            

            
        }
        if (collision.collider.tag == "win")
        {
            
            
           
            Background2.SetActive(true);
            
        }
       
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("obstacle2"))
            {

            
            playerAnimator.SetBool("Die",true);
            Invoke("DestroyBalloon",0.15f);
                

            }
    }


    

    
        
    }
