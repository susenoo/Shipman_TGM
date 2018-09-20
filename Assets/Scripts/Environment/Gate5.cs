using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate5 : MonoBehaviour {

    Rigidbody rd;
    public float interval;

    // Use this for initialization
    void Start()
    {

        rd = GetComponent<Rigidbody>();



    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rd.isKinematic = false;

        }
        else
        {
            rd.isKinematic = true;
            Destroy(gameObject, interval);
        }
    }
/*
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rd.isKinematic = false;

        }
        else
        {
            rd.isKinematic = true;
            Destroy(gameObject, interval);
        }
    }
    */
}
