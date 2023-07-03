using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceController : MonoBehaviour
{
    public int distance;
    public bool isIncreasing = false;
    public GameObject distanceDisplay;
    public GameObject mainCharater;
    public PlayerMove playerMove;

    void Start() {
        playerMove = mainCharater.GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isIncreasing) {
            isIncreasing = true;
            StartCoroutine(DistanceCoroutine());
        }
    }

    IEnumerator DistanceCoroutine() {
        distance += 1;
        distanceDisplay.GetComponent<Text>().text = "" + distance;
        yield return new WaitForSeconds(1.05f/playerMove.moveSpeed);
        isIncreasing = false;
    }
}
