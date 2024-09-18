using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foxscript : MonoBehaviour
{

    public Rigidbody2D testbody;
    public float power;
    public logicScript logic;
    public bool foxIsAlive = true;
    public float ySpeed;
    public Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {
        testbody = GetComponent<Rigidbody2D>();
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && foxIsAlive)
        {
            testbody.velocity = Vector2.up * power;

        }
        
        ySpeed = testbody.velocity.y;
        animator.SetFloat("speed", ySpeed);
        animator.SetBool("foxIsAlive", foxIsAlive);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        foxIsAlive = false;
    }
}
