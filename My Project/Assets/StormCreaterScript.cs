using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StormCreaterScript : MonoBehaviour
{
    [SerializeField] GameObject StormPrefab;
    
    public Transform transform;
    
    
    public void Start()
    {


        


        Invoke("Create",4f);
        
        
    }
    void Create()
    {
        Instantiate(StormPrefab, transform);

    }


    void Update () {

      

        

       



       
    }

   

   
}
