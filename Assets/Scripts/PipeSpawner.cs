using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipes;
    public float spawnTime = 2f;

    public float bottomRange = -4f;
    public float topRange = 6f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipe", 0f, spawnTime);
    }

    void SpawnPipe(){
        Instantiate(pipes, new Vector3(15, Random.Range(bottomRange, topRange),0), Quaternion.identity);
    }
}
