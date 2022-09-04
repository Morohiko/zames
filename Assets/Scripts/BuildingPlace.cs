using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPlace : MonoBehaviour
{
    
    private void OnTriggerExit2D(Collider2D other)
    {
        GetComponentInParent<BuildingsGrid>().available = false;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        GetComponentInParent<BuildingsGrid>().available = true;
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
