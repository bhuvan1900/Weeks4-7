using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class barrelrotate : MonoBehaviour
{
    //float barrel;
    Transform maus;

    void Start()
    {

    }

    void Update()
    {
        Vector2 maus = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.Euler(0, 0, maus.y);

        //if (Input.GetKey(KeyCode.Space))
        //{
        //    barrel += Time.deltaTime * 25;
        //    transform.rotation = Quaternion.Euler(0, 0, barrel);
        //}
    }
}
        