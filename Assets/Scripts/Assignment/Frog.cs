using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Frog : MonoBehaviour
{
    public Slider slider;
    private SpriteRenderer sr;
    private Color original;

    // Start is called before the first frame update
    void Start()
    {
        //original color
        sr = GetComponent<SpriteRenderer>();
        original = sr.color;
    }

    // Update is called once per frame
    void Update()
    {
        //calculates the brightness using slider and applues to sprite
        float brightness = slider.value;
        Color newnew = original* brightness; 
        sr.color = newnew;
    }
}
