using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeBirdManager : MonoBehaviour
{
    [SerializeField] GameObject[] BirdPrefab;
    private float secondSpawn = 20f;
    public float minTras;
    public float maxTras;
    
    void Start()
    {
        Invoke("StartSpawning", 7f);
        
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
            var position = new Vector3(-9.7f, wanted);
            GameObject gameObject = Instantiate(BirdPrefab[Random.Range(0, BirdPrefab.Length)],
            position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
           
        }
    }
    void FixedUpdate()
    {
        
    }

   
}
