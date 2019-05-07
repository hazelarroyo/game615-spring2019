using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image bar;
    public float fill;
    private static float healthPoints;

    void Start()
    {
        fill = 1f; 
    }

    void Update()
    {
        healthPoints = PlayerController.healthPoints;
        bar.fillAmount = healthPoints * .01f;
    }
}
