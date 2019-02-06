using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour

{

    public Text countText;
    public Text winText;

    public Rigidbody rb;
    public float speed = 250f;

    private int count;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText ();
        winText.text = "";
    }

    //Adds movement with default key inputs and adds force to movement

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed * Time.deltaTime);
    }

    //Trigger collider to pick up collectable items in scene - doesn't destroy 
    //objects; deactivates the objects

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count:" + count.ToString();
        if (count >= 33) 
        {
            winText.text = "You Win";
        }

    }
}