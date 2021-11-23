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
            //rb.AddForce(transform.right * -250f);

            GameManager.gameStarted = true;
        }

        if (rb.velocity.x < 1 && rb.velocity.x >= 0)
        {
            rb.AddForce(transform.right * (-50));
        }
        if (rb.velocity.x > 1 && rb.velocity.x < 0)
        {
            rb.AddForce(transform.right * 50);
        }
        if (rb.velocity.y < 1 && rb.velocity.y >= 0)
        {
            rb.AddForce(transform.up * (-50));
        }
        if (rb.velocity.y > 1 && rb.velocity.y < 0)
        {
            rb.AddForce(transform.up * 50);
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "LoseBox")
        {
            Destroy(this.gameObject);
        }
    }
}
