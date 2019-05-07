using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 100f;
    public float jumpForce = 1f; 

    public Quaternion targetRotation;

    //NOTE: Changing this will drastically affect the jumpForce and fall speed.
    float gravityModifier = 0.2f;

    float yVelocity = 0;
    bool previousIsGroundedValue;

    public static float healthPoints = 100f;

    CharacterController cc;

    void Start()
    {
        cc = gameObject.GetComponent<CharacterController>();

        previousIsGroundedValue = cc.isGrounded;

    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        transform.Rotate(0, moveHorizontal * rotateSpeed * Time.deltaTime, 0);

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

        Vector3 amountToMove = transform.forward * moveVertical * moveSpeed * Time.deltaTime;
       
        amountToMove.y = yVelocity;
        cc.Move(amountToMove);

        previousIsGroundedValue = cc.isGrounded;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player collided with enemy.");
            healthPoints = PlayerController.healthPoints - 1f;
            Debug.Log("Health is now:" + healthPoints);
        }
    }

}

