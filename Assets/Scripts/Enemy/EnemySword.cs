using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySword : MonoBehaviour {

    public bool isDamaging;
    public float damage = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
            col.SendMessage((isDamaging) ? "TakeDamage" : "HealDamage", Time.captureFramerate * damage);
    }
}
