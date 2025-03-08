using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameObject coin;
    public LogicScript logicScript;
    public int delay = 5;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer >= delay)
        {
            timer = 0;
            SpawnCoin();
        } else
        {
            timer += Time.deltaTime;
        }
    }
    public void SpawnCoin()
    {
        Instantiate(coin, transform.position, transform.rotation);
    }

}
