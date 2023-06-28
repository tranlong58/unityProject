using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImMotalCollect : MonoBehaviour
{
    public AudioSource coinFx;

    void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.name == "MAIN_PLAYER") {
            coinFx.Play();
            other.gameObject.AddComponent<ImMotal>();
            this.gameObject.SetActive(false);
        }
        
    }
}
