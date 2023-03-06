using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normalmovement : MonoBehaviour
{

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical")> 0)
        {
            rb.AddForce(new Vector3(0,0,-0.1f),ForceMode.Impulse);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            rb.AddForce(new Vector3(0,0,0.1f), ForceMode.Impulse);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            rb.AddForce(new Vector3(-0.1f,0,0), ForceMode.Impulse);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            rb.AddForce(new Vector3(0.1f,0,0), ForceMode.Impulse);
        }



    }
}
