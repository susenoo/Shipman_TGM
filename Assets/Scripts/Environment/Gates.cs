using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gates : MonoBehaviour {

    Rigidbody rd;

	// Use this for initialization
	void Start () {

        rd = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rd.isKinematic = false;
        }
        else
        {
            rd.isKinematic = true;
        }
    }
}
