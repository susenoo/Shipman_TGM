using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {

    float damage = 10f;

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
