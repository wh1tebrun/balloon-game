using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopButtonScript : MonoBehaviour
{
    public GameObject BackgroundStopped;
    void Start()
    {
        
    }

    public void SettingsButtonDown()
    {
        Time.timeScale = 0;
        BackgroundStopped.SetActive(true);
    }
    public void WeiterButtonDown()
    {
        Time.timeScale = 1;
        BackgroundStopped.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
