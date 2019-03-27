using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public Text gameEnd;
    public Text timeUp;
    public Text gameOver;

    public Text timer;
    private bool keepTiming = true;

    private float timeRemaining = 300f;


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
            timer.text = (" ");
            SceneManager.LoadScene("endScreen");
        }

        if(PlayerController.healthPoints < 0f)
        {
            keepTiming = false;
            SceneManager.LoadScene("endScreen"); 
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
        SceneManager.LoadScene("winScreen");
    }

}
