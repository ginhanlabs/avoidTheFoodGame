using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isActive = true;
    private Rigidbody2D rb;
    private float time ;
    private float repeatRate;
    // Start is called before the first frame update
    void Start()
    {
        SetRandomDoor();
        rb = gameObject.GetComponent<Rigidbody2D>();
        InvokeRepeating("OpenDoor", time, repeatRate);
    }

    private void OpenDoor() {
        int isActive = Random.Range(0, 2);
        bool doorStatus = false;
        
        if (isActive == 1) { doorStatus = true; }
        gameObject.SetActive(doorStatus);
        SetRandomDoor();
    }

    private void SetRandomDoor() {
        time = Random.Range(0, 5);
        repeatRate = Random.Range(0, 9);
    }
}
