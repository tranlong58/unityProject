using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void randomContext() {

        Light sunLight = this.gameObject.GetComponent<Light>();
        // random intensity
        sunLight.intensity = Random.Range(0.0f, 1.0f);
        // random rotation
        float ranX = Random.Range(0, 180);
        float ranY = Random.Range(0, 180);
        float ranZ = Random.Range(0, 180);
        this.gameObject.transform.rotation = Quaternion.Euler(ranX, ranY, ranZ);

    }
}
