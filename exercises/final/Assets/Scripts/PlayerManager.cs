using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    private bool changeScene = false;

     #region Singleton

    public static PlayerManager instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject player;

    private void Update()
    {
        if (changeScene)
        {
           SceneManager.LoadScene("LevelTwo");
        }
    }

    private void OnTriggerEnter(Collider Ground)
    {

        if (Ground.gameObject.CompareTag("SceneChange"))
        {
            Debug.Log("Player has entered the trigger");
            changeScene = true;
        }
    }

}

