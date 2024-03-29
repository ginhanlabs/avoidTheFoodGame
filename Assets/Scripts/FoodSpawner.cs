using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject[] foods;
    public float[] startingPositions;
    int index;

    void Start()
    {
        InvokeRepeating("SpawnFood", 1f, 3f);
    }

    void SpawnFood()
    {
        index = Random.Range(0, foods.Length);
        Instantiate(foods[index], new Vector3(startingPositions[index], 5.8f, 0f), foods[index].transform.rotation);
    }
}
