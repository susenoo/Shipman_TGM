using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /*
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ("Player"))
        {
            //rb.isKinematic = false;
            Destroy(col.gameObject);

            //Debug.Log("Hit object and it's tag is player");
        }

    }
    */

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            Destroy(other.gameObject);
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
