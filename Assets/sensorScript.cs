using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensorScript : MonoBehaviour
{
    public logicScript logicScript; 

    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logicScript.addScore();
    }
}
