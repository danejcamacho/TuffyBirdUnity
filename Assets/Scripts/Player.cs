using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //These are the variables for the 'velocity' and 'isMovable' attributes
    //[Header("Player Properties")]
    

    //These will store our jumping and falling sprites
    //[Header("Player Assets")]
    

    //[Header("Events")]
    


    // Start is called before the first frame update
    void Start()
    {
        //when this script is put in the scene, this code runs and gets a reference to the player's components
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //this checks once per frame if you have pressed the space bar and you can move. If so, the player's rigidbody's velocity
        //  is now equal to Vector2.up (aka new Vector2(0,1)) times your velocity value
        

        //checks if the velocity (on the y axis) is less or greater than zero and changes the sprite accordingly


    }

    //checks if the player collided with an object with the tag "Fail" and 
    //plays the hit sound that is stored in SoundEffects's AudioScript.cs
    //then, isMovable is set to false meaning we can't jump anymore
    private void OnCollisionEnter2D(Collision2D other) {
        
    }

    //checks if the player enters the trigger game object and plays a sound if the player is still alive
    // Note the difference in how we get a reference to the "other"'s tag!
    private void OnTriggerEnter2D(Collider2D other) {
        
    }
}
