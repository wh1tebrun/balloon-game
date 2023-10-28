using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public GameObject selectedskin;
    public GameObject Player;


    private Sprite playersprite;
    void Start()
    {
        playersprite = selectedskin.GetComponent<SpriteRenderer>().sprite;


        Player.GetComponent<SpriteRenderer>().sprite = playersprite;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
