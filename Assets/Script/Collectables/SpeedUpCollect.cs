using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpCollect : MonoBehaviour
{
    public AudioSource coinFx;

    void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.name == "MAIN_PLAYER") {
            coinFx.Play();
            // other.gameObject.GetComponent<SpeedUp>().enabled = true;
            other.gameObject.AddComponent<SpeedUp>();
            this.gameObject.SetActive(false);
        }
        
    }
}
