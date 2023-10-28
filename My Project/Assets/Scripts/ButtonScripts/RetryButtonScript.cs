using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtonScript : MonoBehaviour

{
    public GameObject Background;
    public void RetryButtonFunction()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
        Background.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
