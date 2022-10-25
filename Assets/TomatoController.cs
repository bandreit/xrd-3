using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoController : MonoBehaviour
{
    private const string ToolTag = "Shovel";
    public GameObject TomatoPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag(ToolTag))
        return;
        Vector3 position = this.gameObject.transform.position;
       Instantiate(TomatoPrefab, position + new Vector3(0f,1f,0f), Quaternion.identity);
 Instantiate(TomatoPrefab, position + new Vector3(0.2f,1f,0f), Quaternion.identity);
  Instantiate(TomatoPrefab, position + new Vector3(0.2f,1.1f,0.3f), Quaternion.identity);

       gameObject.SetActive(false);
    }
}
