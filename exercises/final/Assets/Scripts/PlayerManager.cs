using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    #region Singleton

    public static PlayerManager instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("SceneChange"))
        {
            Debug.Log("Player has entered the trigger");
            UpdateEnd();
        }
    }

    void UpdateEnd()
    {
        SceneManager.LoadScene("LevelTwo");
    }

}

