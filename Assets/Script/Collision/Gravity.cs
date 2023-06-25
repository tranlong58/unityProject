using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Gravity : MonoBehaviour
{
    public float gravity = 9.8f;
    public CharacterController characterCtl;

    // Start is called before the first frame update
    void Start()
    {
        characterCtl = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(characterCtl.isGrounded);
        if (!characterCtl.isGrounded)
            transform.Translate(Vector3.down * Time.deltaTime * gravity);
    }

    // void Awake() {
    //     characterCtl = GetComponent<CharacterController>();
    // }

}
