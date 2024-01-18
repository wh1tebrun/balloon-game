using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointCounterScript : MonoBehaviour
{


    [SerializeField] TMP_Text PointCounterText; 
    private float Score = 0;
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

        Score += Time.deltaTime;
        PointCounterText.text = Score.ToString("0");

        
    }
}
