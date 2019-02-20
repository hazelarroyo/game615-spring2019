using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour

{

    public Rigidbody rb;
    public float speed = 50f;

    private int score;
    public Text scoreText;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
    }

    //Adds movement with default key inputs and adds force to movement

    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    //Trigger collider to pick up collectable items in scene - doesn't destroy 
    //objects; deactivates the objects

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            score = score + 1;
            UpdateScore();
        }
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

   
}