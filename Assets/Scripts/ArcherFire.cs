using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherFire : MonoBehaviour
{
    public float speed = 10f;
    public GameObject bullet;
    public GameObject cannon_tip;

    private Vector2 lookDirection;
    private float lookAngle;

    void Start()
    {

    }

    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, lookAngle);
         //transform.LookAt(transform.position - GetComponent<Rigidbody2D>().velocity);


        if (Input.GetMouseButtonDown(2))
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject bullet_instance = Instantiate(bullet, cannon_tip.transform.position, transform.rotation);
        bullet_instance.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
    }
}
