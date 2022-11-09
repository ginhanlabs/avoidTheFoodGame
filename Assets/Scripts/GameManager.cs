using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public GameObject[] lives;
    public TextMeshProUGUI scoreText;
    private int health;
    // private GameObject FoodSpawner;

    void Start()
    {
        // FoodSpawner = GameObject.Find("Food Spawner");
        health = lives.Length;
        score = 0;
    }

    public void  AddScore() {
        scoreText.text = "Score: " + score++;
    }

    public void UpdateHealth() { 
        health--;
            if (health >= 0) {
            Debug.Log(health);
            lives[health ].SetActive(false);
        } 

        if (health < 0) {
            GameOver();
        }
    }

    public void GameOver() {
        Debug.Log("Game Over");
    }
}
