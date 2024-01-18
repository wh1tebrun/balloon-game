using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;




public class BalloonScript : MonoBehaviour
{



    
    [SerializeField] private SpriteRenderer skinSprite;

    public SkinDatabase skinDatabase;
    private int selectedSkin = 0;
    Rigidbody2D rb2d;
    Gun[] guns;
    
    

    //[SerializeField] GameObject RegenPrefab;
    public GameObject Background;
    public float cloudSpeed;
    public float cloudTimer;
    public bool cloudSlowing;
    private bool SlowAreaActivated = false;
    private float SlowAreaTimer = 0f;
    private bool BalloonBoosterBird = false;
    private float BalloonBoosterBirdTimer = 0;
    Animator playerAnimator;
    
    
     
    
    
   


    

    
    private float shootTimer = 40;
    private float moveSpeed = 4.5f;
    private float upSpeed = 1f;
    private float boostTimer;
    private float breakTimer;
    private Collider2D balloon;
    private bool boosting;
    private bool breaking;
    private bool invisible = true;
    private float activationTime;
    private bool eTetiklendiMi;
    public CircleCollider2D collider;
    private float ozelZaman = 50;
    private bool moveLeft, moveRight;
   
    public UnityEvent RightButtonClicked;
    

    public const string RIGHT = "right";
    public const string LEFT = "left";
   

    string buttonPressed;



    bool shoot;




    



    
    void Start()
    {

        if(PlayerPrefs.HasKey("selectedSkin"))
    {
        Load();
    }
    else
    {
        selectedSkin = 0;
    }


    UpdateSkin(selectedSkin);

        playerAnimator = GetComponent<Animator>();


        guns = transform.GetComponentsInChildren<Gun>();

        moveLeft = false;
        moveRight = false;



        eTetiklendiMi = false;
        collider.enabled = true;
        collider = GetComponent<CircleCollider2D>();
        
        
        activationTime = 10;
        

        
        rb2d = GetComponent<Rigidbody2D>();
        boostTimer = 20;
        breakTimer = 45;
        boosting = false;
        breaking = false;
    }
   

    public void SkillInvisible()
    {
       
        eTetiklendiMi = true;
    }



    public void SkillBreak()
    {
        if(breakTimer>=44){

        
        breaking = true;
        

        }

    }
    


    public void SkillSpeed()
    {

        if(boostTimer >= 20)
        {
            boosting = true;
            upSpeed = upSpeed * 2;
            
        
            boostTimer = 0;
            
        }
       

    }
    public void SkillBullet()
    {
        if(shootTimer >=60)
        {
            shootTimer = 0;
            shoot = true;
            if(shoot)
            {
                shoot = false;
             foreach(Gun gun in guns)
                {
                    gun.Shoot();
             }
            }
            
        }
        
    }
    

    



    public void MoveLeft()
    {
        moveLeft = true;

    }
     public void MoveRight()
    {
        moveRight = true;

    }
    

    public void StopMoving()
    {
        moveLeft = false;
        moveRight = false;

    }

    
    private void FixedUpdate()

    {
        Debug.Log(upSpeed);

        
        







        if(moveLeft)
        {
            rb2d.velocity = new Vector2(-moveSpeed, upSpeed);
        }
        else if(moveRight)
        {
            rb2d.velocity = new Vector2(moveSpeed, upSpeed);
        }
        else
        {
            rb2d.velocity = new Vector2(0f, upSpeed);
        }        
       
        if(ozelZaman>= 50){

        
            collider.enabled = true;
            

            }
        
        
     

        
        ozelZaman += Time.deltaTime;
        activationTime += Time.deltaTime;
        breakTimer += Time.deltaTime;
        boostTimer += Time.deltaTime;
        shootTimer += Time.deltaTime;
        SlowAreaTimer += Time.deltaTime;
        BalloonBoosterBirdTimer += Time.deltaTime;


        if(BalloonBoosterBird)
            {
                if(BalloonBoosterBirdTimer >= 4)
                {
                    upSpeed = upSpeed/2;
                    BalloonBoosterBird = false;
                }
            }



        if(SlowAreaActivated)
        {

            if(upSpeed > 0 && upSpeed < 1.1f)
            {
                upSpeed = 0.67f;
            }

            else if(upSpeed > 1 && upSpeed < 2.1f)
            {
                upSpeed = 1.34f;
            }
            else if(upSpeed > 2.1f)
            {
                upSpeed = 2.68f;
            }

            if(SlowAreaTimer>=0.5f)
            {
                upSpeed = upSpeed * 1.5f;
                SlowAreaActivated = false;

            }
            

        }

        

        if(Input.GetKeyDown("e"))
        {
            
           eTetiklendiMi = true;
           
        }

        
        
        
        
            
        

       
       
        if(Input.GetKeyDown("w") && breakTimer>=44)
        {
            breaking = true;
            
            

            }
        
        
        
        
        
        if(boosting)
        {
            
            
            
            
            if(boostTimer >= 3)
            {
                upSpeed = upSpeed / 2;
                
                boosting = false;
            }
        }
        //if (Input.GetKeyDown("q"))
       // {
           // boosting = true;
          //  upSpeed = 2;
           // boostTimer = 0;
        //}

       



         if (Input.GetKey(KeyCode.RightArrow))
        {
            buttonPressed = RIGHT;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            buttonPressed = LEFT;
        }
        
        else
        {
            buttonPressed = null;
        }
       
        
    }
   
    

   // public void FixedUpdate()
   // {
        



       // if(buttonPressed == RIGHT){
          //  rb2d.velocity = new Vector2(moveSpeed, upSpeed);

       // }

       // else if(buttonPressed == LEFT)
       // {
       //     rb2d.velocity = new Vector2(-moveSpeed, upSpeed);

      //  }
        
      //  else
      //  {
        //    rb2d.velocity = new Vector2(0, upSpeed);

      //  }
   // }
   void OnCollisionEnter2D(Collision2D collisionInfo2)
   {
    if (collisionInfo2.collider.tag == "BalloonBoost")
            {
            upSpeed = upSpeed * 2;
            BalloonBoosterBird = true;
            BalloonBoosterBirdTimer = 0;
            

            }
   }
   

    void OnCollisionStay2D (Collision2D collisionInfo)
    {
      
        

        
        if (collisionInfo.collider.tag == "wolke" && breakTimer >=45 && breaking)
        {
            breakTimer = 0;
            Destroy(collisionInfo.collider.gameObject);
            breaking = false;
            
        }
           if (collisionInfo.collider.tag == "wolkeblack1" && breakTimer >=45 && breaking)
        {
            breakTimer = 0;
            Destroy(collisionInfo.collider.gameObject);
            //Instantiate(RegenPrefab, GameObject.FindWithTag("wolkeblack1").transform);
            breaking = false;
            
        }
        if (collisionInfo.collider.tag == "wolkeblack2" && breakTimer >=45 && breaking)
        {
            breakTimer = 0;
            Destroy(collisionInfo.collider.gameObject);
            //Instantiate(RegenPrefab, GameObject.FindWithTag("wolkeblack2").transform);
            breaking = false;
            
        }
        if (collisionInfo.collider.tag == "wolkeblack3" && breakTimer >=45 && breaking)
        {
            breakTimer = 0;
            Destroy(collisionInfo.collider.gameObject);
            //Instantiate(RegenPrefab, GameObject.FindWithTag("wolkeblack3").transform);
            breaking = false;
            
        }
        if (collisionInfo.collider.tag == "wolkeblack4" && breakTimer >=45 && breaking)
        {
            breakTimer = 0;
            Destroy(collisionInfo.collider.gameObject);
            //Instantiate(RegenPrefab, GameObject.FindWithTag("wolkeblack4").transform);
            breaking = false;
            
        }
        if (collisionInfo.collider.tag == "wolkeblack5" && breakTimer >=45 && breaking)
        {
            breakTimer = 0;
            Destroy(collisionInfo.collider.gameObject);
            //Instantiate(RegenPrefab, GameObject.FindWithTag("wolkeblack5").transform);
            breaking = false;
            
        }
        if (collisionInfo.collider.tag == "wolkeblack6" && breakTimer >=45 && breaking)
        {
            breakTimer = 0;
            Destroy(collisionInfo.collider.gameObject);
            //Instantiate(RegenPrefab, GameObject.FindWithTag("wolkeblack6").transform);
            breaking = false;
            
        }
        if (collisionInfo.collider.tag == "wolkeblack7" && breakTimer >=45 && breaking)
        {
            breakTimer = 0;
            Destroy(collisionInfo.collider.gameObject);
            //Instantiate(RegenPrefab, GameObject.FindWithTag("wolkeblack7").transform);
            breaking = false;
            
        }
        if (collisionInfo.collider.tag == "wolkeblack8" && breakTimer >=45 && breaking)
        {
            breakTimer = 0;
            Destroy(collisionInfo.collider.gameObject);
            //Instantiate(RegenPrefab, GameObject.FindWithTag("wolkeblack8").transform);
            breaking = false;
            
        }
        if (collisionInfo.collider.tag == "wolkeblack9" && breakTimer >=45 && breaking)
        {
            breakTimer = 0;
            Destroy(collisionInfo.collider.gameObject);
            //Instantiate(RegenPrefab, GameObject.FindWithTag("wolkeblack9").transform);
            breaking = false;
            
        }
        



        if (collisionInfo.collider.tag == "wolke" &&  activationTime >=11 && eTetiklendiMi && invisible){
          
            
            activationTime = 0;
            eTetiklendiMi = false;
            collider.enabled = false;
            ozelZaman = 49.5f;
            
            
            invisible = false;

            

            }
        if (collisionInfo.collider.tag == "wolkeblack1" &&  activationTime >=11 && eTetiklendiMi && invisible){
          
            
            activationTime = 0;
            eTetiklendiMi = false;
            collider.enabled = false;
            ozelZaman = 49.5f;
            
            
            invisible = false;

            

            }
            if (collisionInfo.collider.tag == "wolkeblack2" &&  activationTime >=11 && eTetiklendiMi && invisible){
          
            
            activationTime = 0;
            eTetiklendiMi = false;
            collider.enabled = false;
            ozelZaman = 49.5f;
            
            
            invisible = false;

            

            }
            if (collisionInfo.collider.tag == "wolkeblack3" &&  activationTime >=11 && eTetiklendiMi && invisible){
          
            
            activationTime = 0;
            eTetiklendiMi = false;
            collider.enabled = false;
            ozelZaman = 49.5f;
            
            
            invisible = false;

            

            }
            if (collisionInfo.collider.tag == "wolkeblack4" &&  activationTime >=11 && eTetiklendiMi && invisible){
          
            
            activationTime = 0;
            eTetiklendiMi = false;
            collider.enabled = false;
            ozelZaman = 49.5f;
            
            
            invisible = false;

            

            }
            if (collisionInfo.collider.tag == "wolkeblack5" &&  activationTime >=11 && eTetiklendiMi && invisible){
          
            
            activationTime = 0;
            eTetiklendiMi = false;
            collider.enabled = false;
            ozelZaman = 49.5f;
            
            
            invisible = false;

            

            }
            if (collisionInfo.collider.tag == "wolkeblack6" &&  activationTime >=11 && eTetiklendiMi && invisible){
          
            
            activationTime = 0;
            eTetiklendiMi = false;
            collider.enabled = false;
            ozelZaman = 49.5f;
            
            
            invisible = false;

            

            }
            if (collisionInfo.collider.tag == "wolkeblack7" &&  activationTime >=11 && eTetiklendiMi && invisible){
          
            
            activationTime = 0;
            eTetiklendiMi = false;
            collider.enabled = false;
            ozelZaman = 49.5f;
            
            
            invisible = false;

            

            }
            if (collisionInfo.collider.tag == "wolkeblack8" &&  activationTime >=11 && eTetiklendiMi && invisible){
          
            
            activationTime = 0;
            eTetiklendiMi = false;
            collider.enabled = false;
            ozelZaman = 49.5f;
            
            
            invisible = false;

            

            }
            if (collisionInfo.collider.tag == "wolkeblack9" &&  activationTime >=11 && eTetiklendiMi && invisible){
          
            
            activationTime = 0;
            eTetiklendiMi = false;
            collider.enabled = false;
            ozelZaman = 49.5f;
            
            
            invisible = false;

            

            }
            
        
    
        
        



          
        
            
                

                
          


          }
          void OnTriggerStay2D (Collider2D colliderInfo)
          {

            if (colliderInfo.gameObject.CompareTag("SlowArea"))
            {


                SlowAreaActivated = true;
                SlowAreaTimer = 0;

            }


            
            
                

            
            


            

          }
          void OnTriggerEnter2D (Collider2D other)
          {

            
            if (other.gameObject.CompareTag("Storm"))
            {

            
                Destroy(this.gameObject);
                Background.SetActive(true);
                Time.timeScale = 0;
                

            }
            
                

            

          }








          private void UpdateSkin(int selected)
   {
    SkinBase skinBase = skinDatabase.GetSkin(selected);
    skinSprite.sprite = skinBase.skinSprite;
    

   }

   private void Load()
   {
    selectedSkin = PlayerPrefs.GetInt("selectedSkin");

   }
         
         
    


          
            
            

            
          
    

    

        
        

            

            
        

        
        

        
    
    

    }


    

    




