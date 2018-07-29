using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjects : MonoBehaviour {

    public float FallSpeed;
    Rigidbody rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
		
	}

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag ==("Player"))
            rb.isKinematic = false;
    }

    private void OnTriggerEnter(Collision col)
    {
        if (col.gameObject.tag ==("Player"))
            
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
