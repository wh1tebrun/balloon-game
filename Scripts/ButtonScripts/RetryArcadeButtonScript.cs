using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryArcadeButtonScript : MonoBehaviour

{
    public GameObject Background;
    public void RetryButtonFunction()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("ArcadeScene");
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
