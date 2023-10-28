using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonMenuScript : MonoBehaviour
{
    public void ButtonMenuFunction()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuScene");
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
