using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 0.0005f;
    private float dedzone = -25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; 
        if ( transform.position.x < dedzone)
        {
            Destroy(gameObject);
        }
    }
}
