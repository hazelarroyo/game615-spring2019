﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    public Text gameEnd;
    public Text timeUp;

    public Text timer;
    private bool keepTiming = true;

    private float timeRemaining = 60f;


    void Update()
    {
        if (keepTiming)
        {
            timeRemaining = timeRemaining - Time.deltaTime;
            timer.text = (timeRemaining).ToString("0");
        }


        if (timeRemaining < 0f)
        {
            keepTiming = false;
            timeUp.text = "Time's Up!";
            timer.text = (" ");
        }

       
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player has entered the trigger");
            timer.text = (" ");
            keepTiming = false;
            UpdateEnd();
        }
    }

    void UpdateEnd()
    {
        gameEnd.text = "You Win!";
    }

}
