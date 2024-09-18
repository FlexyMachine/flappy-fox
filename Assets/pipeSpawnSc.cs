using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnSc : MonoBehaviour
{
    public GameObject pipeObj;
    public float spawnRate = 1;
    private float timer = 0;
    public float heightOffset = 10;
    


    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }

    }
    void SpawnPipe()
    {
        float lowest = transform.position.y - heightOffset;
        float highest = transform.position.y + heightOffset;

        Instantiate(pipeObj, new Vector3(transform.position.x , Random.Range(lowest,highest),0), transform.rotation);
    }

}
