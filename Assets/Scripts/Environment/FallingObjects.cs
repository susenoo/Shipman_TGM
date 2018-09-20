using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjects : MonoBehaviour {

    //public float FallSpeed;
    Rigidbody rb;
    public float resetDelay;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();
		
	}

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == ("Player"))
        {
            rb.isKinematic = false;

            
        }
    }
    private void Reset()
    {
        Time.timeScale = 1f;

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ("Player"))
        {
            rb.isKinematic = false;
            Destroy(col.gameObject);
            Time.timeScale = 0.5f;
            Invoke("Reset", resetDelay);
            Application.LoadLevel(Application.loadedLevel);

            Debug.Log("Hit object and it's tag is player");
        }
            
    }

    // Update is called once per frame
    void Update () {
		
	}
    

    
}
