using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float enemy_speed = 0.1f;
    
    // public int max_health = 100;
    public int current_health;
    // public HealthBar healthbar;

    Rigidbody2D rb;

    /* obj to get access to healtbar visibility*/
    // Canvas healthbar_canvas; 

    void Start()
    {
        // // healthbar_canvas = GetComponentInChildren<Canvas>();
        // rb = GetComponent<Rigidbody2D>();

        // /* dynamic bodytype to make enemy properly grounded */
        // rb.bodyType = RigidbodyType2D.Dynamic;

        // /* do not show healthar if no damage received */
        // healthbar_canvas.enabled = false;

        // current_health = max_health;
        // healthbar.setMaxHealth(max_health);
    }

    void Update()
    {
        // if (current_health < max_health)
        // {
        //     /* show healthbar */
        //     // healthbar_canvas.enabled = true;
        //     // healthbar.setHealth(current_health);
        // }

        if (current_health <= 0)
        {   
            // Debug.Log("Enemy Destroy");
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        transform.position =  new Vector2(transform.position.x - enemy_speed, transform.position.y);
    }
    
     void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log("Enemy: Collision " + collision.gameObject.tag);

        /* destroy if end of way */
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }
        
        // if (collision.gameObject.tag == "ground")
        // {
        //     /* switch to kinematic to disable dynamic movements*/
        //     //rb.bodyType = RigidbodyType2D.Kinematic;
        // }
    }

    public void ReduceHealth(int health_points)
    {
        current_health = current_health - health_points;
    }
}
