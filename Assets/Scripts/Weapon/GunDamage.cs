using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunDamage : MonoBehaviour {

    float damage = 5;

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<MeleeHealth>().TakeDamage(damage);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
