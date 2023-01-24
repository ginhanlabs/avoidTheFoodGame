using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isActive = true;
    public  bool doorStatus = false;
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
        // TODO fix DOOR, player can run throug it.
        int isActive = Random.Range(0, 2);
        doorStatus = false;
        
        if (isActive == 1) {
         doorStatus = true; 
        }
        gameObject.SetActive(doorStatus);
        SetRandomDoor();
    }

    private void SetRandomDoor() {
        time = Random.Range(0, 5);
        repeatRate = Random.Range(0, 9);
    }
}
