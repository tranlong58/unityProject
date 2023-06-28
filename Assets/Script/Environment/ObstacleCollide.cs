using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollide : MonoBehaviour
{
    public GameObject mainChar;
    public GameObject mainAnim;
    public AudioSource collideAudio;
    public GameObject mainCamera;
    public GameObject levelControl;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "MAIN_PLAYER" && 
            other.gameObject.GetComponent<ImMotal>() == null)
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            mainChar.GetComponent<PlayerMove>().enabled = false;
            mainAnim.GetComponent<Animator>().Play("Stumble Backwards");
            collideAudio.Play();
            mainCamera.GetComponent<Animator>().enabled = true;
            levelControl.GetComponent<DistanceController>().enabled = false;
            levelControl.GetComponent<EndFrame>().enabled = true;
        }
        
    }
}
