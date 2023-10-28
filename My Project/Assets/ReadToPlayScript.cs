using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadToPlayScript : MonoBehaviour
{
    public GameObject ReadToPlayPanel;

    bool etwas = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Time.timeScale = 0;
    }


    public void OnClickGo()
    {
        ReadToPlayPanel.SetActive(false);
        Time.timeScale = 1;
        
    }
    public void OnClickBack()
    {
       SceneManager.LoadScene("MenuScene");
    }



   
}
