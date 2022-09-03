using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsGrid : MonoBehaviour
{
    public Vector2Int GridSize = new Vector2Int(10,10);
    public Building[,] grid;
    private Building flyingBuilding;

    private void Awake()
    {
        grid = new Building[GridSize.x, GridSize.y];
    }

    public void StartPlacingBuilding(Building buildingPrefab)
    {
        if (flyingBuilding != null)
        {
            Destroy(flyingBuilding.gameObject);
        }
        
        flyingBuilding = Instantiate(buildingPrefab);
    }
    
    void Update()
    {
        if (flyingBuilding != null)
        {
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            // int x = Mathf.RoundToInt(worldPosition.x);
            // int y = Mathf.RoundToInt(worldPosition.y);

            float x = worldPosition.x;
            float y = worldPosition.y;
            
            bool available = true;
            
            /* out of range */
            // if (x < 0 || x > GridSize.x - flyingBuilding.size.x) available = false;
            // if (y < 0 || y > GridSize.y - flyingBuilding.size.y) available = false;
            if (available && IsPlaceTaken(x, y)) available = false;

            flyingBuilding.transform.position = new Vector2(x, y);
            flyingBuilding.SetTransparent(available);

            if (available && Input.GetMouseButtonDown(0))
            {
                PlaceFlyingBuilding(x, y);
            }
        }
    }

    private bool IsPlaceTaken(float placeX, float placeY)
    {
        // for (int x = 0; x < flyingBuilding.size.x; x++)
        // {
        //     for (int y = 0; y < flyingBuilding.size.y; y++)
        //     {
        //         if (grid[placeX + x, placeY + y] != null)
        //             return true;
        //     }
        // }

        return false;
    }
    
    private void PlaceFlyingBuilding(float placeX, float placeY)
    {
        // for (int x = 0; x < flyingBuilding.size.x; x++)
        // {
        //     for (int y = 0; y < flyingBuilding.size.y; y++)
        //     {
        //         grid[placeX + x, placeY + y] = flyingBuilding;
        //     }
        // }
        
        flyingBuilding.SetNormal();
        flyingBuilding = null;
    }
}
