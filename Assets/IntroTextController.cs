using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroTextController : MonoBehaviour
{
    GameObject text;

    void Start()
    {
        StartCoroutine(ShowAndHide(5));
    }

    IEnumerator ShowAndHide(float delay)
    {
        text = GameObject.FindWithTag("intro_text");

        if (text != null)
        {
            text.SetActive(true);
            yield return new WaitForSeconds(delay);
            text.SetActive(false);
        }

    }
}
