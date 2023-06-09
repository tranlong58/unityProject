using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollide : MonoBehaviour
{
    public GameObject mainChar;
    public GameObject mainAnim;

    void OnTriggerEnter(Collider other) {
        Debug.Log("mc111111111111111111");
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        mainChar.GetComponent<PlayerMove>().enabled = false;
        mainAnim.GetComponent<Animator>().Play("Stumble Backwards");
    }
}
