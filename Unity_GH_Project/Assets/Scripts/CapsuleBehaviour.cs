using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleBehaviour : MonoBehaviour
{
    Vector3 capPos;
    Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        capPos = this.transform.position;
        //Debug.LogFormat("Current Capsule Position is:{0}",capPos);
        mousePos = Input.mousePosition;
        //Debug.LogFormat("Current Mouse Position is:{0}", mousePos);
        if (Input.GetMouseButton(0))
        {
            Destroy(gameObject);
        }
    }
    
}
