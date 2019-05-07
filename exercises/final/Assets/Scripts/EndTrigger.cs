using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{

    void Update()
    {
        if(PlayerController.healthPoints < 0f)
        {
            SceneManager.LoadScene("endScreen");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player has entered trigger.");
            UpdateEnd();
        }
    }

    void UpdateEnd()
    {
        SceneManager.LoadScene("winScreen");
    }
}
