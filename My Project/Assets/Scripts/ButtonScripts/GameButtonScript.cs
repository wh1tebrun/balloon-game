using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameButtonScript : MonoBehaviour
{
    public void GameButtonFunction()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
