using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed = 10f;
    public float xPosToDestroy = -30f;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-speed,0,0) * Time.deltaTime;
        if(transform.position.x <= xPosToDestroy){
            Destroy(gameObject);
        }
    }
}
