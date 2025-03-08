using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;

    public float flapStrength = 50;
    public LogicScript logicScript;

   
    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
       
        rigidBody.isKinematic = true;
        

    }

    // Update is called once per frame
    void Update()
    {
        
        if(logicScript.status == 0)
        {
            transform.position = new Vector3(0, 0, 0);
                
        }
        
        if (Input.GetKeyDown(KeyCode.Space) == true && logicScript.status == 1)
        {
            rigidBody.isKinematic = false;
            rigidBody.velocity = Vector2.up * flapStrength;
        }
       
    }
   
}
