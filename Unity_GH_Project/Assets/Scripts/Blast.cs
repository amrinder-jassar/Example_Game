using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour
{
    public GameObject grpBlast;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Vector3 spawnPos = new Vector3(transform.position.x, 2f, transform.position.z);
        Instantiate(grpBlast, spawnPos, grpBlast.transform.rotation);
        Destroy(gameObject);
    }
}
