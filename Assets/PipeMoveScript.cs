using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float pipeSpeed = 2;
    int deadzone = -26;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (transform.position.x <= deadzone)
        {
            Debug.Log("Pipe destroyed");
            Destroy(gameObject);
        }
        transform.position += Vector3.left * pipeSpeed * Time.deltaTime;
    }
}
