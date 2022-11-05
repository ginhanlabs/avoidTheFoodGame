using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMove : MonoBehaviour
{
    private float lowBoundary = -6.4f;
    public float repeatRate;

    void Start()
    {
        InvokeRepeating("fallDown", 2f, repeatRate);
    }
    
    void fallDown()
    {
        transform.position += Vector3.down;
        if (transform.position.y < lowBoundary) {
            Destroy(gameObject);
        }
    }
}
