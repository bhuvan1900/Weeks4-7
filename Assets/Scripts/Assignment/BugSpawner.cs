using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BugSpawner : MonoBehaviour
{
    public GameObject bugfab;

    public void OnClick()
    {
        //makes a bug at a random spot (within range) and then destroys it after 10 secs
            Vector3 bugpos = transform.position;
            bugpos = new Vector3(Random.Range(7, -7), (Random.Range(5, -5)));
            GameObject x =  Instantiate(bugfab, bugpos, Quaternion.identity);
            Destroy(x, 10);
    }
}
