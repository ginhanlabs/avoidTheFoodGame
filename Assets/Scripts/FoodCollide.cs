using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollide : MonoBehaviour
{
    private void  OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            // put pause here
            Destroy(gameObject);
            GameManager.instance.UpdateHealth();
            Debug.Log("hit");
        }
         
    }
}