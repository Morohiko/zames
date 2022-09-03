using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Color = System.Drawing.Color;
using Vector3 = UnityEngine.Vector3;

public class Building : MonoBehaviour
{
    public Vector2Int size = Vector2Int.one;
    private Renderer renderer;

    void Start()
    {   
        Debug.Log("TEST");
        renderer = GetComponent<Renderer>();
    }

    private void OnDrawGizmosSelected()
    {
        for (int x = 0; x < size.x; x++)
        {
            for (int y = 0; y < size.y; y++)
            {
                Gizmos.color = new UnityEngine.Color(1f, 0.1f, 0.29f, 0.35f);
                Gizmos.DrawCube(transform.position + new Vector3(x,y,0), new Vector3(1, 1, 0));
            }
        }
    }

    public void SetTransparent(bool available)
    {
        renderer.material.color = (available) ? UnityEngine.Color.green : UnityEngine.Color.red;
    }

    public void SetNormal()
    {
        renderer.material.color = UnityEngine.Color.white;
    }
    void Update()
    {

    }
}
