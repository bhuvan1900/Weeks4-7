using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public GameObject go;
    public SpriteRenderer sr;
    public EnableDisable script;
    public AudioSource audioSource;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //script.enabled = false;
            //sr.enabled = false;
            go.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //script.enabled = true;
            // sr.enabled = true;
            go.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Space))
        {
           if(audioSource.isPlaying)
              {
                audioSource.PlayOneShot(clip);

                //      audioSource.Play();
            }
            //audioSource.PlayOneShot(clip);
        }
    }
}
