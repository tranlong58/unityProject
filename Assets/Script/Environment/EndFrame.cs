using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndFrame : MonoBehaviour
{
    public GameObject coin, distance, endFrame;
    public GameObject curCoin, curDistance;
    public GameObject scoreFrame;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DisplayCoroutine());
    }

    IEnumerator DisplayCoroutine() {
        coin.GetComponent<Text>().text = curCoin.GetComponent<Text>().text;
        distance.GetComponent<Text>().text = curDistance.GetComponent<Text>().text;
        yield return new WaitForSeconds(5);
        endFrame.SetActive(true);
        scoreFrame.SetActive(false);
    }
}
