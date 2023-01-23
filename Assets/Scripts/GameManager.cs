using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score;
    public bool doorStatus;
    public GameObject[] lives;
    public TextMeshProUGUI scoreText;
    private int health;

   private void Awake() {
        instance = this;   
    }

    void Start()
    {
        health = lives.Length;
        score = 0;
    }

    public void  AddScore() {
        if (score == 0) {
            score = 1;
        } else {
            score++;
        }
        scoreText.text = "Score: " + score;
    }

    public void UpdateHealth() { 
        Debug.Log("in updteHealth");
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
