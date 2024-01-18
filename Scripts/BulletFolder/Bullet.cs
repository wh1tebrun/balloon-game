using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector2 direction = new Vector2(0, 5);
    public Vector2 velocity;
    [SerializeField] GameObject RegenPrefab;


   

    public float BulletSpeed = 5f;
    public Rigidbody2D rb2d;
    public Transform transformRegen;
    


   void Start()
    {
        Destroy(gameObject, 0.3f);
        
        

    }
    void CreateRegen()
    {
        Instantiate(RegenPrefab, transformRegen);

    }


    void Update()
    {
        velocity = direction * BulletSpeed;
    }
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos += velocity * Time.fixedDeltaTime;

        transform.position = pos;
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.GetComponent<Collider2D>().tag == "wolke")
        {
             
            Destroy(col.GetComponent<Collider2D>().gameObject);
             
            
        }
        if (col.GetComponent<Collider2D>().tag == "wolkeblack")
        {
             
            Destroy(col.GetComponent<Collider2D>().gameObject);
            CreateRegen();
             
            
        }

    }

    
   
}
