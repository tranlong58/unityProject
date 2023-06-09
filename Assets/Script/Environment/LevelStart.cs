using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStart : MonoBehaviour
{
    public GameObject countDown3, countDown2, countDown1, countDownGo, fadeIn;
    public AudioSource countDownFX, goFX;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(countCoroutine());
    }

    IEnumerator countCoroutine() {
        yield return new WaitForSeconds(1.5f);
        countDown3.SetActive(true);
        countDownFX.Play();
        yield return new WaitForSeconds(1f);
        countDown2.SetActive(true);
        countDownFX.Play();
        yield return new WaitForSeconds(1f);
        countDown1.SetActive(true);
        countDownFX.Play();
        yield return new WaitForSeconds(1f);
        countDownGo.SetActive(true);
        goFX.Play();
        PlayerMove.canMove = true;
    }
}
