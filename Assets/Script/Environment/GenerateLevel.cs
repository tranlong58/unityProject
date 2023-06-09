using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] sections;
    public int zPos = 70;
    public bool isCreatingSection = false;
    public int secNum;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCreatingSection == false) {
            isCreatingSection = true;
            StartCoroutine(GenerateSection());
        }
        
    }

    IEnumerator GenerateSection() {
        secNum = Random.Range(0, 4);
        Instantiate(sections[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 70;
        yield return new WaitForSeconds(5);
        isCreatingSection = false;
    }
}
