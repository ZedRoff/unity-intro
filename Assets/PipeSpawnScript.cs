using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    private float spawnDelay = 4;
    public float timer = 0;

    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(timer);
        Debug.Log(spawnDelay);
        if (timer < spawnDelay)
        {
            timer += Time.deltaTime;

        } else
        {
            SpawnPipe();
            timer = 0;
            
        }
        
    }
    public void SpawnPipe()
    {
        Instantiate(pipe, transform.position + (new Vector3(0, Random.Range(transform.position.y - heightOffset, transform.position.y + heightOffset), 0)), transform.rotation);

    }
}
