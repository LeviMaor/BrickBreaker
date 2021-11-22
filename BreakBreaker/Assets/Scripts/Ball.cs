using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    
    void Movement()
    {
        if(GameManager.startGame == true && GameManager.gameStarted == false)
        {
            rb.AddForce(transform.up * 500f);
            rb.AddForce(transform.right * -250f);

            GameManager.gameStarted = true;
        }
    }
}
