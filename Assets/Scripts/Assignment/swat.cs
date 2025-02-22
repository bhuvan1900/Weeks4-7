using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class swat : MonoBehaviour
{
    SpriteRenderer sr;
    bool follow = false; 

    void Start()
    {
        //the swat sprite is off 
        sr = GetComponent<SpriteRenderer>();
        sr.enabled = false; 
    }

    public void OnClick2()
    {
        //buton turns sr on or off
        follow = !follow; 
        if (follow)
        {
            sr.enabled = true; 
        }
        else
        {
            sr.enabled = false; 
        }
    }

    void Update()
    {
        if (follow)
        {
            //swat follows mouse
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mouse;
        }
    }
}

