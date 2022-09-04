using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject obj;
    public float speed = 2;

    void Start()
    {
        
    }

    void Update()
    {
        /* camera is controlled by keys */
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.position = new Vector3(this.transform.position.x - speed, this.transform.position.y, this.transform.position.z);
        } else
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.position = new Vector3(this.transform.position.x + speed, this.transform.position.y, this.transform.position.z);
        }
        
        /* camera follows person object */        
        //this.transform.position = new Vector3(obj.transform.position.x, this.transform.position.y, this.transform.position.z);
    }
}
