using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color previousJacketColor;
    public Color previousPantsColor;
    public Renderer pants, jacket;
    // Start is called before the first frame update
    void Start()
    {
        jacket = this.gameObject.transform.Find("mixamorig:Meshes").Find("mixamorig:Jacket_Geo").gameObject.GetComponent<Renderer>();
        pants = this.gameObject.transform.Find("mixamorig:Meshes").Find("mixamorig:Pants_Geo").gameObject.GetComponent<Renderer>();

        previousJacketColor = jacket.material.color;
        previousPantsColor = pants.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeClothColor(Color color) {
        jacket.material.color = color;
        pants.material.color = color;
    }

    public void RecoverClothColor() {
        jacket.material.color = previousJacketColor;
        pants.material.color = previousPantsColor;
    }
}
