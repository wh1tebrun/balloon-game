using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectingGoBackScript : MonoBehaviour
{
    
    void Start()
    {
        
    }

    public void OnClick()
    {
        SceneManager.LoadScene("ShopCenter");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
