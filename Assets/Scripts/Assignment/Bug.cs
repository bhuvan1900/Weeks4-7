using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{

    public float bugrotspeed ;
    float speedincreaser=0;

    void Update()
    {
        //rotates the bug prefab
        Vector3 bugrot = transform.eulerAngles;
        bugrot.z += bugrotspeed + speedincreaser;
        transform.eulerAngles = bugrot;
    }
}
