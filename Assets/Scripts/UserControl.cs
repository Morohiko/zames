using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl : MonoBehaviour
{
    private SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start() {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {
        
    }

    private void OnMouseDown() {   
        renderer.color = Color.red;
        Debug.Log(this.gameObject.tag + "[" + this.gameObject.transform.position.x + ":" + this.gameObject.transform.position.y + "]");
    }
}
