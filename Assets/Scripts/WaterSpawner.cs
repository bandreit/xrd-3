using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject parent;
    private float spawnTime = 0.17f;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnTime = Random.Range(0.13f, 0.17f);
        InvokeRepeating ("SpawnDrop", spawnTime, spawnTime);
    }

    void SpawnDrop()
    {
        if (parent.transform.rotation.eulerAngles.x >= 70  )
        {
            prefab.transform.localScale = new Vector3(0.03f, 0.03f, 0.03f);
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}
