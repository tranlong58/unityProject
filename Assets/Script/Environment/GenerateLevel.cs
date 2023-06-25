using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] sections;
    public int zPos = 70;
    public bool isCreatingSection = false;
    public bool isDestroyingSection = false;
    public int secNum;
    public List<GameObject> createdSections = new List<GameObject>();


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

        if (!isDestroyingSection) {
            isDestroyingSection = true;
            StartCoroutine(DestroySection());
        }
        
    }

    IEnumerator GenerateSection() {
        secNum = Random.Range(0, 4);
        
        createdSections.Add(Instantiate(sections[secNum], new Vector3(0, 0, zPos), Quaternion.identity));
        
        zPos += 70;
        yield return new WaitForSeconds(20); 
        isCreatingSection = false;
    }

    IEnumerator DestroySection() {

        
        
        if (createdSections.Count > 2)
        {
            Destroy(createdSections[0]);
            createdSections.RemoveAt(0);
             
        }
        yield return new WaitForSeconds(25);
        isDestroyingSection = false;
    }
}
