using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            InvokeRepeating("PoisonDamage", 1f, 1f);
        }
    }
}
