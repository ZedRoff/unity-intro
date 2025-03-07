using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;

    public float flapStrength = 50;
    public LogicScript logicScript;
    public bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        isActive = true;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) == true && isActive)
        {
            rigidBody.velocity = Vector2.up * flapStrength;
        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isActive = false;
        logicScript.GameOver();
    }
}
