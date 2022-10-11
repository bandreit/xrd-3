using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private String cameraTag = "MainCamera";
    private Canvas canvas;
    private bool didEnter = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        // GameObject canvasObj = GameObject.FindGameObjectWithTag("Canvas");
        // canvas = canvasObj.GetComponent<Canvas>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(cameraTag))
        {
            if (didEnter) return;
            animator.SetBool("isDancing", true);
            canvas.enabled = true;
            didEnter = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(cameraTag))
        {
            animator.SetBool("isDancing", false);
            animator.SetBool("isWaving", true);
        }
    }


    // public void FirstButton()
    // {
    //     Debug.Log("Button 1");
    //     canvas.enabled = false;
    // }
    //
    // public void SecondButton()
    // {
    //     Debug.Log("Button 2");
    //     canvas.enabled = false;
    // }
    //
    // public void ThirdButton()
    // {
    //     Debug.Log("Button 3");
    //     canvas.enabled = false;
    // }
    //
    // public void FourthButton()
    // {
    //     Debug.Log("Button 4");
    //     canvas.enabled = false;
    // }
}