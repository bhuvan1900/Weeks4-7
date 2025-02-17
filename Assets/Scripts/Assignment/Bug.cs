using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    public float bugrotspeed ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

 

    // Update is called once per frame
    void Update()
    {
        Vector3 bugrot = transform.eulerAngles;
        bugrot.z += bugrotspeed;
        transform.eulerAngles = bugrot;
    }

    public void EatenByFrog()
    {
         
       
    }
}
