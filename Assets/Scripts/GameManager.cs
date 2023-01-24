using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Door door;
    public int score;
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

    public void  AddScore(int amount) {
       score += amount;
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

    public bool GetDoorStatus() {
        return door.doorStatus;
    }
}
