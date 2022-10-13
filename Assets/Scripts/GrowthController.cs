using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthController : MonoBehaviour
{
    [SerializeField] private GameObject[] vegetables;
    [SerializeField] private int repeatTime = 7;
    [SerializeField] private bool isCarrot = false;
    
    private float growTime = 2f;
    private float initialScale = 0f;
    private bool isWatered = false;
    private int count = 0;
    void Start()
    {
        InvokeRepeating ("VegetablesToGrow", growTime, growTime);
        foreach (var vegetable in vegetables)
        {
            vegetable.transform.localScale = new Vector3(initialScale, initialScale, initialScale);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Drop"))
        { 
            isWatered = true;
            foreach (var vegetable in vegetables)
            {
                vegetable.SetActive(true);
            }
        }
    }

    void VegetablesToGrow()
    {
        if (isWatered && count < repeatTime)
        {
            ScaleUp();
            count++;
            initialScale += isCarrot ? 0.1f :0.2f;
        }
    }

    private void ScaleUp()
    {
        foreach (var vegetable in vegetables)
        {
            float randomScale = initialScale + Random.Range(0.1f, 0.18f);
            float scaleToAssign = isCarrot ? initialScale : randomScale;
            vegetable.transform.localScale = new Vector3(scaleToAssign, scaleToAssign, scaleToAssign);
        }
    }
}
