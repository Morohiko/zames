using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float damage = 50;
    public float delete_arrow_time = 1;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Bullet: Trigger " + collision.gameObject.tag);
        

        // if (collision.gameObject.tag == "limit")
        // {
        //     Destroy(gameObject);
        // }
        
        if (collision.gameObject.tag == "Ground")
        {
            Invoke("destroyArrow", delete_arrow_time);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            collision.gameObject.GetComponent<EnemyMove>().ReduceHealth(50);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bullet: Collision " + collision.gameObject.tag);
    }

    void destroyArrow()
    {
        Destroy(gameObject);
    }
}
