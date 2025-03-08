using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeColisionScript : MonoBehaviour
{
    public LogicScript logicScript;
    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.SetStatus(2);
        logicScript.GameOver();
    }
}
