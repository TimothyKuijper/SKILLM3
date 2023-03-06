using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceTracketr : MonoBehaviour
{
    int Bouncess;
    // Start is called before the first frame update
    void Start()
    {
        Bouncess = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bouncess += 1;
        Debug.Log(Bouncess);
    }
}
