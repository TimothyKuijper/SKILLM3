using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{

    Animator ani;

    // Start is called before the first frame update
    void Start()
    {
            ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            ani.SetTrigger("run");
            ani.ResetTrigger("run back");
            ani.SetBool("IsRunning",true);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            ani.SetTrigger("run back");
            ani.ResetTrigger("run");
            ani.SetBool("IsRunning", true);
        }
        else
        {
            ani.ResetTrigger("run");
            ani.ResetTrigger("run back");
            ani.SetBool("IsRunning", false);
        }
    }
}
