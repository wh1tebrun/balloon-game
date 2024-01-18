using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButtonScript : MonoBehaviour
{

    public GameObject SettingsPart;
    public void ÖffnenEinstellungen()
    {
       SettingsPart.SetActive(true);
    }
    public void SchliessenEinstellungen()
    {
       SettingsPart.SetActive(false);
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
