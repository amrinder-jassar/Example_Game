using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    //###############################
    //USING ACCELEROMETER for game///

    private Rigidbody rb;
    public bool isFlat = true;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 tilt = Input.acceleration;
        if (isFlat)
        {
            tilt = Quaternion.Euler(90,0,0) * tilt;// so that you can put phone flat as default position.
        }
        rb.AddForce(tilt);
        Debug.DrawRay(transform.position + Vector3.up, tilt, Color.red);
    }
}
