using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideEffect : MonoBehaviour
{
    public float timeLife = 0f;

    void Awake() {
        // enabled = false;
    }

    void OnEnable() {
        timeLife = 0f;
        activate();
    }

    // Start is called before the first frame update
    void Start()
    { 
  
    }

    // Update is called once per frame
    void Update()
    {
        timeLife += Time.deltaTime;
        if (timeLife > 15f)
        {
            deActivate();
        }
    }

    public virtual void activate() {

    }

    public virtual void deActivate() {

    }

}
