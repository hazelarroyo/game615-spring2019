using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image bar;
    public float fill;
    private static float healthPoints;

    // Start is called before the first frame update
    void Start()
    {
        fill = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        healthPoints = PlayerController.healthPoints;
        bar.fillAmount = healthPoints * .01f;
    }
}
