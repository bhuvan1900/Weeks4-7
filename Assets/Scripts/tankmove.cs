using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankmove : MonoBehaviour
{
     private Transform pos;
    public float speed = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 pos = transform.position;
            pos.x += speed;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 pos = transform.position;
            pos.x += -speed;
            transform.position = pos;
        }
    }
}
