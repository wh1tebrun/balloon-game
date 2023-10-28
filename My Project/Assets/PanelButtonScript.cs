using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelButtonScript : MonoBehaviour
{


    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void onClick()
    {
        SceneManager.LoadScene("Panel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
