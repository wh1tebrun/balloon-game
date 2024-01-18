using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeWolkeErsteller : MonoBehaviour
{
    [SerializeField] GameObject[] ArcadeWolke;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    
    void Start()
    {
        StartCoroutine(ArcadeWolkeSpawn());
        
    }

    IEnumerator ArcadeWolkeSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(ArcadeWolke[Random.Range(0, ArcadeWolke.Length)],
            position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject,5f);
        }
    }

   
}
