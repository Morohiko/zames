using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMovement : MonoBehaviour
{
    private float playerSpeed = 5.0f;
    private Rigidbody2D rigidBody;

    private bool isSelected = false;
    private bool isMoving = false;
    private SpriteRenderer renderer;
    private Vector2 newPersonPosition;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Test only
        // TODO: move it to UserControl.cs
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("Input.GetMouseButtonDown(0)");
        }
        if (Input.GetMouseButtonDown(1)) {
            Debug.Log("Input.GetMouseButtonDown(1)");
            if (isSelected) {
                Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                newPersonPosition = new Vector2(worldPosition.x, worldPosition.y);
                isMoving = true;
            }
        }
        //

        renderer.color = isSelected ? Color.black : Color.white;
        MovePlayer();
    }

    void setIsSelected(bool isSelected) {
        this.isSelected = isSelected;
    }

    private void OnMouseDown() {
        isSelected = true;
    }

    private void MovePlayer()
    {
        int horizontalInput = 0;
        if ((this.transform.position.x - newPersonPosition.x) < 0.1 &&
            (this.transform.position.x - newPersonPosition.x) > -0.1) {
            isMoving = false;
        }
        if (!isMoving) {
            horizontalInput = 0;
        }
        if (isMoving && this.transform.position.x > newPersonPosition.x) {
            horizontalInput = -1;
        }
        if (isMoving && this.transform.position.x < newPersonPosition.x) {
            horizontalInput = 1;
        }
        rigidBody.velocity = new Vector2(horizontalInput * playerSpeed, rigidBody.velocity.y);    
    }
}