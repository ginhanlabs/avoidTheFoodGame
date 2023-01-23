using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public  float speed;
    private float maxStage;
    private float maxStage17 = 17f;
    private float maxStage19 = 21f;
    float defaultSteps = 2.0f;

    void Start() {
      maxStage = maxStage17;
    }

    void Update()
    {
        float currentPos = transform.position.x;
        if (Input.GetKeyDown(KeyCode.RightArrow ))  {
            if (currentPos + defaultSteps < maxStage) {
                transform.Translate(Vector3.right + new Vector3(defaultSteps, 0, 0));
            }
        };
           
    
        if (Input.GetKeyDown(KeyCode.LeftArrow) ) {
              if (currentPos - .5 > 0) {
                transform.Translate(Vector3.left - new Vector3(defaultSteps, 0, 0));
              }
        }
    } 
}
