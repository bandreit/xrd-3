using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotManager : MonoBehaviour
{
    public int interactedWithShovel;
    private const string ToolTag = "Shovel";
    Renderer rend;
    private float duration = 4f; // duration in seconds
    private float t = 0f;
    private Color colorStart;
    private Color colorEnd;

    private void Awake()
    {
        interactedWithShovel = 0;
    }

    private void Start()
    {
        rend = GetComponent<Renderer> ();
        colorStart = rend.material.color;
        colorEnd = colorStart;
    }

    private void Update()
    {
        switch (interactedWithShovel)
        {
            case 1:
                colorEnd = new Color(colorStart.r - 0.2f, colorStart.g - 0.2f, colorStart.b - 0.2f, colorStart.a);
                break;
            case 2:
                colorEnd = new Color(colorStart.r - 0.4f, colorStart.g - 0.4f, colorStart.b - 0.4f, colorStart.a);
                break;
            case 3:
                colorEnd = new Color(colorStart.r - 0.5f, colorStart.g - 0.5f, colorStart.b - 0.5f, colorStart.a);
                break;
        }
        
        if (interactedWithShovel > 0)
        {
            rend.material.color = Color.Lerp(colorStart, colorEnd, t);
        
            if (t < 1){ // while t below the end limit...
                // increment it at the desired rate every update:
                t += Time.deltaTime/duration;
            }
        }
       
    }

    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag(ToolTag))
            return;

        colorStart = rend.material.color;
        interactedWithShovel += 1;
        t = 0;

    }
}
