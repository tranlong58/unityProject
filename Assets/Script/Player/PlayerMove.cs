using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public float leftRightSpeed = 4;
    public float jumpSpeed = 4;
    public static bool canMove = false;
    public bool isJumping = false;
    public bool comingDown = false;
    public GameObject playerObject;
    // Start is called before the first frame update
    void Start()
    {
        // moveSpeed = 3;
        // leftRightSpeed = 4;
        // jumpSpeed = 4;
        this.gameObject.name = "MAIN_PLAYER";
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (canMove)
        {
            if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                }
            }
            
            if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if(this.gameObject.transform.position.x < LevelBoundary.rightSide) 
                {
                    transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed);
                }
            } 

            if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                if(isJumping == false)
                {
                    isJumping = true;
                    playerObject.GetComponent<Animator>().Play("Joyful Jump");
                    StartCoroutine(JumSequence());
                }
            }
        }

        if(isJumping == true)
        {
            if(comingDown == false) 
            {
                transform.Translate(Vector3.up * Time.deltaTime * jumpSpeed, Space.World);
            }

            if(comingDown == true) 
            {
                transform.Translate(Vector3.down * Time.deltaTime * jumpSpeed, Space.World);
            }
        }
        else {
            playerObject.GetComponent<Animator>().Play("Run");
        }    
    }

    IEnumerator JumSequence()
    {
        float initHeight = transform.position.y;
        yield return new WaitForSeconds(0.5f);
        comingDown = true;
        yield return new WaitForSeconds(0.5f);
        isJumping = false;
        comingDown = false;
        transform.position = new Vector3(transform.position.x, initHeight, transform.position.z);
    }
}
