using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    public Text gameEnd;
    public Text timeUp;

    private float timeRemaining = 90f;

    void Update()
    {
        timeRemaining = timeRemaining - Time.deltaTime;

        if (timeRemaining < 0f)
        {
            timeUp.text = "Time's Up!";
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player has entered the trigger");
            UpdateEnd();
        }
    }

    void UpdateEnd()
    {
        gameEnd.text = "You Win!";
    }

}
