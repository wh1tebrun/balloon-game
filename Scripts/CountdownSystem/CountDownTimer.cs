using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
     public GameObject Background;
     public GameObject Balloon;
    
   

   float currentTime = 0f;
   float startingTime = 60f;

   [SerializeField] TMP_Text countdownText; 

   void Start()
   {
        currentTime = startingTime;
   }

   void Update()
   {

     if (currentTime >= 59.1f)
     {
          Time.timeScale = 1;
     }
      
    currentTime -= 1 * Time.deltaTime;
    countdownText.text = currentTime.ToString ("0");
        if (currentTime <= 0)
        {
         
          Destroy(Balloon);
          Destroy(countdownText);
          Background.SetActive(true);




      
     

     }
     
    
   
}


}
