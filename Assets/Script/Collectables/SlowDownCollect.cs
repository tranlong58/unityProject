using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDownCollect : MonoBehaviour
{
    public AudioSource coinFx;

    void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.name == "MAIN_PLAYER") {
            coinFx.Play();
            other.gameObject.AddComponent<SlowDown>();
            this.gameObject.SetActive(false);
        }
        
    }
}
