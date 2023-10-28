using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegenScript6 : MonoBehaviour
{
    public GameObject RegenPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject == null)
        {
            Instantiate(RegenPrefab);
        }
    }
}
