using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDrops8 : MonoBehaviour
{
    Vector2 pos;
    float speed;
    bool count = false;
    // Use this for initialization
    void Start()
    {
        speed = 5f;
        //pos.y = this.transform.position.y;
        this.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }
    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -10)
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        }
        if (this.transform.position.y > 0
           )
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;
        }
        //pos.x = this.transform.position.x;
        //pos.y += speed;
        //transform.position = pos;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("IS pig");
        if (collision.gameObject.CompareTag("Environment"))
        {
            if (count == false)
            {
                this.GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;
                count = true;
            }
            else
            {
                this.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
                count = false;
            }
        }

    }
}