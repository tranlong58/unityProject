using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkVertical : MonoBehaviour
{
    public int speed = 0;
    public bool isUp = true;
    public float yMin = 2.7f;
    public float yMax = 6f;

    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
        yMin = 2.7f;
        yMax = 6f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isUp) {
            if (transform.position.y + speed*Time.deltaTime > yMax) {
                isUp = false;
            } else {
                transform.Translate(new Vector3(0, speed*Time.deltaTime, 0));
            }
        } else {
            if (transform.position.y + speed*Time.deltaTime < yMin) {
                isUp = true;
            } else {
                transform.Translate(new Vector3(0, -1*speed*Time.deltaTime, 0));
            }
        }
        
    }
}
