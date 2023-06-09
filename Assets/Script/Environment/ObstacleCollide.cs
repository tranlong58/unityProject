using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollide : MonoBehaviour
{
    public GameObject mainChar;
    public GameObject mainAnim;
    public AudioSource collideAudio;
    public GameObject mainCamera;

    void OnTriggerEnter(Collider other) {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        mainChar.GetComponent<PlayerMove>().enabled = false;
        mainAnim.GetComponent<Animator>().Play("Stumble Backwards");
        collideAudio.Play();
        mainCamera.GetComponent<Animator>().enabled = true;
    }
}
