using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public AudioSource coinFx;

    void OnTriggerEnter(Collider other) {
        coinFx.Play();
        CollectableController.cointCount += 1;
        this.gameObject.SetActive(false);
    }
}
