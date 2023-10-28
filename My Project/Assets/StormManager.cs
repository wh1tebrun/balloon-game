using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StormManager : MonoBehaviour
{
    [SerializeField] GameObject[] StormPrefab;
    private float secondSpawn = 10f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    void Start()
    {
        Invoke("StartSpawning", 2f);
        
    }
    void StartSpawning()
    {
        StartCoroutine(StormSpawn());

    }

    IEnumerator StormSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(StormPrefab[Random.Range(0, StormPrefab.Length)],
            position, Quaternion.identity);
            Destroy(gameObject,5f);
            yield return new WaitForSeconds(secondSpawn);
            
            
        }
    }

   
}
