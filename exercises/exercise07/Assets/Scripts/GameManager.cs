using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject playerCharacter;

    public Image fadePanelImg;

    public GameObject playerPanel1;
    public GameObject playerPanel2;
    public GameObject playerPanel3;
    public GameObject playerPanel4;
    public GameObject playerPanel5;
    public GameObject playerPanel6;
    public GameObject playerPanel7;
    public GameObject playerPanel8;

    public GameObject jasonPanel1;
    public GameObject jasonPanel2;
    public GameObject jasonPanel3;
    public GameObject jasonPanel4;
    public GameObject jasonPanel5;
    public GameObject jasonPanel6;
    public GameObject jasonPanel7;
    public GameObject jasonPanel8;
    public GameObject jasonPanel9;


    void Start()
    {
        StartCoroutine(fadeIn());
        playerPanel1.SetActive(false);
        playerPanel2.SetActive(false);
        playerPanel3.SetActive(false);
        playerPanel4.SetActive(false);
        playerPanel5.SetActive(false);
        playerPanel6.SetActive(false);
        playerPanel7.SetActive(false);
        playerPanel8.SetActive(false);

        jasonPanel1.SetActive(false);
        jasonPanel2.SetActive(false);
        jasonPanel3.SetActive(false);
        jasonPanel4.SetActive(false);
        jasonPanel5.SetActive(false);
        jasonPanel6.SetActive(false);
        jasonPanel7.SetActive(false);
        jasonPanel8.SetActive(false);
        jasonPanel9.SetActive(false);
    }

    void Update()
    {

    }

    IEnumerator fadeIn()
    {
        while (fadePanelImg.color.a > 0)
        {
            float newAlpha = fadePanelImg.color.a - 0.5f * Time.deltaTime;
            fadePanelImg.color = new Color(0, 0, 0, newAlpha);

            //This line will end the function for this round of Unity's update cycle (at time=n)
            yield return null;
            //This is where the Unity update cycle will enter at time=n+1
        }

        fadePanelImg.gameObject.SetActive(false);

        StartCoroutine(jasonAndPlayerScene());
    }

    IEnumerator jasonAndPlayerScene()
    {
        while (true)
        {
            playerPanel1.SetActive(true);

            yield return new WaitForSeconds(3);

            playerPanel1.SetActive(false);
            jasonPanel1.SetActive(true);

            yield return new WaitForSeconds(3);

            jasonPanel1.SetActive(false);
            playerPanel2.SetActive(true);

            yield return new WaitForSeconds(2);

            playerPanel2.SetActive(false);
            playerPanel3.SetActive(true);

            yield return new WaitForSeconds(4);

            playerPanel3.SetActive(false);
            jasonPanel2.SetActive(true);

            yield return new WaitForSeconds(3);

            jasonPanel2.SetActive(false);
            playerPanel4.SetActive(true);

            yield return new WaitForSeconds(2);

            playerPanel4.SetActive(false);
            jasonPanel3.SetActive(true);

            yield return new WaitForSeconds(2);

            jasonPanel3.SetActive(false);
            playerPanel5.SetActive(true);

            yield return new WaitForSeconds(3);

            playerPanel5.SetActive(false);
            jasonPanel4.SetActive(true);

            yield return new WaitForSeconds(5);

            jasonPanel4.SetActive(false);
            playerPanel6.SetActive(true);

            yield return new WaitForSeconds(5);

            playerPanel6.SetActive(false);
            jasonPanel5.SetActive(true);

            yield return new WaitForSeconds(4);

            jasonPanel5.SetActive(false);
            playerPanel7.SetActive(true);

            yield return new WaitForSeconds(2);

            playerPanel7.SetActive(false);
            jasonPanel6.SetActive(true);

            yield return new WaitForSeconds(3);

            jasonPanel6.SetActive(false);
            playerPanel8.SetActive(true);

            yield return new WaitForSeconds(5);

            playerPanel8.SetActive(false);
            jasonPanel7.SetActive(true);

            yield return new WaitForSeconds(2);

            jasonPanel7.SetActive(false);
            jasonPanel8.SetActive(true);

            yield return new WaitForSeconds(3);

            jasonPanel8.SetActive(false);
            jasonPanel9.SetActive(true);

            yield return new WaitForSeconds(5);

            jasonPanel9.SetActive(false);

            yield return new WaitForSeconds(2000);

        }

    }

}
