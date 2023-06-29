using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public int level = 1, countSection = 0;
    public List<GameObject> sectionLv1  = new List<GameObject>(),
     sectionLv2  = new List<GameObject>(),
      sectionLv3  = new List<GameObject>(),
       sectionLv4  = new List<GameObject>(),
        sectionLv5 = new List<GameObject>();
    public int zPos = 70;
    public bool isCreatingSection = false;
    public bool isDestroyingSection = false;
    public int secNum;
    public List<GameObject> createdSections;
    public GameObject mainCharater;
    public float sectionIndex = 1;
    public PlayerMove playerMove;


    // Start is called before the first frame update
    void Start()
    {
        level = 1;
        countSection = 0;
        sectionIndex = 1;
        playerMove = mainCharater.GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        // update speed
        sectionIndex = ((mainCharater.transform.position.z + 4) / 70f) + 1; // 4 is initial position

        if (sectionIndex <= 3)
        {
            playerMove.moveSpeed = 3;
        } else if (sectionIndex <= 6)
        {
            playerMove.moveSpeed = 4;
        } else if (sectionIndex <= 10)
        {
            playerMove.moveSpeed = 5;
        } else if (sectionIndex <= 14)
        {
            playerMove.moveSpeed = 6;
        } else {
            playerMove.moveSpeed = 7;
        }


        // update level
        if (countSection <= 2)
        {
            level = 1;
        } else if (countSection <= 5)
        {
            level = 2;
        } else if (countSection <= 9)
        {
            level = 3;
        } else if (countSection <= 13)
        {
            level = 4;
        } else {
            level = 5;
        }

        // create level
        if (isCreatingSection == false) {
            isCreatingSection = true;
            StartCoroutine(GenerateSection());
        }

        // destroy level
        if (!isDestroyingSection) {
            isDestroyingSection = true;
            StartCoroutine(DestroySection());
        }
        
    }

    IEnumerator GenerateSection() {
        
        
        if(level == 1) {
            secNum = Random.Range(0, sectionLv1.Count);
            createdSections.Add(Instantiate(sectionLv1[secNum], new Vector3(0, 0, zPos), Quaternion.identity));
        } else if (level == 2)
        {
            secNum = Random.Range(0, sectionLv2.Count);
            createdSections.Add(Instantiate(sectionLv2[secNum], new Vector3(0, 0, zPos), Quaternion.identity));
        } else if (level == 3)
        {
            secNum = Random.Range(0, sectionLv3.Count);
            createdSections.Add(Instantiate(sectionLv3[secNum], new Vector3(0, 0, zPos), Quaternion.identity));
        } else if (level == 4)
        {
            secNum = Random.Range(0, sectionLv4.Count);
            createdSections.Add(Instantiate(sectionLv4[secNum], new Vector3(0, 0, zPos), Quaternion.identity));
        } else
        {
            secNum = Random.Range(0, sectionLv5.Count);
            createdSections.Add(Instantiate(sectionLv5[secNum], new Vector3(0, 0, zPos), Quaternion.identity));
        } 

        
        countSection += 1;
        zPos += 70;
        yield return new WaitForSeconds(15); 
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
