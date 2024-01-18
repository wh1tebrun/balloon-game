using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ArcadeGameButtonScript : MonoBehaviour
{
    public void ArcadeGameButtonFunction()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("ArcadeScene");
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
