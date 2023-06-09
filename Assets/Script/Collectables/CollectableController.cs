using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableController : MonoBehaviour
{
    public static int cointCount;
    
    public GameObject cointCountDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cointCountDisplay.GetComponent<Text>().text = "" + cointCount;
    }
}
