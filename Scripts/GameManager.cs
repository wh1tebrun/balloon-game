using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float gameFastCounter;
    void Start()
    {
        
    }

    
    void Update()
    {
        gameFastCounter += Time.deltaTime;





        if(gameFastCounter >= 30)
        {
            Time.timeScale = 1.2f;
        }
           if(gameFastCounter >= 66)
        {
            Time.timeScale =Time.timeScale * 1.2f;
        }
           if(gameFastCounter >= 109.2f)
        {
            Time.timeScale = Time.timeScale * 1.2f;
        }
           if(gameFastCounter >= 161.04f)
        {
            Time.timeScale = Time.timeScale * 1.2f;
        }
           if(gameFastCounter >= 223.248f)
        {
            Time.timeScale = Time.timeScale * 1.2f;
        }
           if(gameFastCounter >= 297.8976f)
        {
            Time.timeScale = Time.timeScale * 1.2f;
        }





    
        
    }
}
