using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdManagerScript : MonoBehaviour
{
    [SerializeField] GameObject[] BirdPrefab;
    private float secondSpawn = 15f;
    public float minTras;
    public float maxTras;
    private float CreateTimer = 0;
    
    private void Start()
    {
        Invoke("StartSpawning" , 5f);
        
    }
    private void FixedUpdate()
    {

        
        
        
    }

    void StartSpawning()
    {
        StartCoroutine(BirdSpawn());

    }

    IEnumerator BirdSpawn()
    {
        
        
            while (true)
            {
                var wanted = Random.Range(minTras, maxTras);
                var position = new Vector3(-9f, wanted);
                GameObject gameObject = Instantiate(BirdPrefab[Random.Range(0, BirdPrefab.Length)],
                position, Quaternion.identity);
                yield return new WaitForSeconds(secondSpawn);
                Destroy(gameObject,5f);
            }

        
        
        
            

        

            
        
        
    }

   
}
