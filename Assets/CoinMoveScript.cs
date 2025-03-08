using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMoveScript : MonoBehaviour
{
    public float coinSpeed = 5;
    int deadzone = -26;
    public LogicScript logicScript;

    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x <= deadzone)
        {
            Debug.Log("Coin destroyed");
            Destroy(gameObject);
        }

        if (logicScript.status == 1) transform.position += Vector3.left * coinSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logicScript.AddScore(3);
        Destroy(gameObject);
    }
   
}
