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
}