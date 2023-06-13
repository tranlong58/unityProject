using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkHorizontal : MonoBehaviour
{
    public int speed = 3;
    // public bool isLeft = true;
    public float distance = 0;

    // Update is called once per frame
    void Update()
    {
        distance += speed*Time.deltaTime;
        transform.Translate(new Vector3(0, 0, speed*Time.deltaTime));


        if (distance >= 7f)
        {
            distance = 0;
            // isLeft = !isLeft;
            this.gameObject.GetComponent<Animator>().Play("attack01");
            transform.Rotate(new Vector3(0, 180, 0));
        }
    }
}
