using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //These are the variables for the 'velocity' and 'isMovable' attributes
    [Header("Player Properties")]
    public float velocity = 10.0f;
    public float jump_power = 10.0f;
    private bool isMovable = true;


    //Declaring our components
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    public AudioScript audioScript;

    //These will store our jumping and falling sprites
    [Header("Player Assets")]
    public Sprite jumping;
    public Sprite falling;

    [Header("Events")]
    public UnityEngine.Events.UnityEvent died;
    public UnityEngine.Events.UnityEvent scored;


    // Start is called before the first frame update
    void Start()
    {
        //when this script is put in the scene, this code runs and gets a reference to the player's components
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //this checks once per frame if you have pressed the space bar and you can move. If so, the player's rigidbody's velocity
        //  is now equal to Vector2.up (aka new Vector2(0,1)) times your velocity value
        if(Input.GetKeyDown(KeyCode.Space) && isMovable){
            audioScript.PlayJumpSound();
            rb.velocity = Vector2.up * jump_power;
        }

        //checks if the velocity (on the y axis) is less or greater than zero and changes the sprite accordingly
        if (rb.velocity.y > 0){
            spriteRenderer.sprite = jumping;
        }else{
            spriteRenderer.sprite = falling;
        }


    }

    //checks if the player collided with an object with the tag "Fail" and 
    //plays the hit sound that is stored in SoundEffects's AudioScript.cs
    //then, isMovable is set to false meaning we can't jump anymore
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Fail" && isMovable ){
            audioScript.PlayHitSound();
            isMovable = false;
            died.Invoke();
        }
    }

    //checks if the player enters the trigger game object and plays a sound if the player is still alive
    // Note the difference in how we get a reference to the "other"'s tag!
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Score" && isMovable ){
            audioScript.PlayScoreSound();
            scored.Invoke();

        }
        
    }
}
