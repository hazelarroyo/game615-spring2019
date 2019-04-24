

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 100f;
    public float jumpForce = 1f;

    //NOTE: Changing this will drastically affect the jumpForce and fall speed.
    float gravityModifier = 0.1f;

    float yVelocity = 0;
    bool previousIsGroundedValue;

    CharacterController cc;

    private int score;
    public Text scoreText;
    public Text winScoreText;

    public static float healthPoints = 100f;

    void Start()
    {
        cc = gameObject.GetComponent<CharacterController>();

        previousIsGroundedValue = cc.isGrounded;

        score = 0;

    }

    void Update()
    {

        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        transform.Rotate(0, hAxis * rotateSpeed * Time.deltaTime, 0);


        //--- DEALING WITH GRAVITY ---
        if (!cc.isGrounded)
        {
            yVelocity = yVelocity + Physics.gravity.y * gravityModifier * Time.deltaTime;

            if (Input.GetKeyUp(KeyCode.Space) && yVelocity > 0)
            {
                yVelocity = 0;
            }
        }
        else
        {
            if (!previousIsGroundedValue)
            {
                yVelocity = 0;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = jumpForce;
            }
        }

        Vector3 amountToMove = transform.forward * vAxis * moveSpeed * Time.deltaTime;

        amountToMove.y = yVelocity;
        cc.Move(amountToMove);

        previousIsGroundedValue = cc.isGrounded;



    }

    //Trigger collider to pick up collectable items in scene - doesn't destroy 
    //objects; deactivates the objects



    void UpdateScore()
    {
        scoreText.text = "" + score;
    }

    void UpdateEnding()
    {
        winScoreText.text = "You Win!";
    }

}

