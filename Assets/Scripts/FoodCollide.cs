using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollide : MonoBehaviour
{
    private GameManager gameManager;

    void Start() {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    private void  OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            // put pause here
            Destroy(gameObject);
            gameManager.UpdateHealth();
            Debug.Log("hit");
        }
         
    }
}