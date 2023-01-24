using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public  float speed;
    public Vector3 transformPosition;
    private float maxStage;
    private float maxStage17 = 17f;
    float defaultSteps = 2.0f;

    void Start() {
      maxStage = maxStage17;
    }

    void Update()
    {
        Debug.Log("Door = " + GameManager.instance.GetDoorStatus());
        if (GameManager.instance.GetDoorStatus()) {
            maxStage = maxStage17;
        } else {
            maxStage = maxStage17 + 1.2f;
        }

        float currentPos = transform.position.x;
        if (Input.GetKeyDown(KeyCode.RightArrow ))  {
            if (currentPos + defaultSteps < maxStage) {
                transform.Translate(Vector3.right + new Vector3(defaultSteps, 0, 0));
            }

            if (currentPos > maxStage) {
                Debug.Log(currentPos + " more than " + maxStage);
                GameManager.instance.AddScore(5);
                transform.position = transformPosition;
            } 
        };
           
    
        if (Input.GetKeyDown(KeyCode.LeftArrow) ) {
              if (currentPos - .5 > 0) {
                transform.Translate(Vector3.left - new Vector3(defaultSteps, 0, 0));
              }
        }
    } 

}
