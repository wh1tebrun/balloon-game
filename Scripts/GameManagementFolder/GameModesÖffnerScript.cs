using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModesÖffnerScript : MonoBehaviour
{
    public GameObject GameModesPanel;
    public void ÖffnenGameModesPanel()
    {
       GameModesPanel.SetActive(true);
    }
    public void SchliessenGameModesPanel()
    {
       GameModesPanel.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
