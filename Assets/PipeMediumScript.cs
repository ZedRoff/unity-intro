using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMediumScript : MonoBehaviour
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logicScript.AddScore(1);
    }
}
