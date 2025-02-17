using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BugSpawner : MonoBehaviour
{
    public GameObject bugfab;

  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.deltaTime > 5)
        {

        }
   
    }

    public void BugNumber()
    {
        
    }

    public void OnClick()
    {
            Vector3 bugpos = transform.position;
            bugpos = new Vector3(Random.Range(7, -7), (Random.Range(5, -5)));
            GameObject x =  Instantiate(bugfab, bugpos, Quaternion.identity);
            Destroy(x, 10);
    }
}
