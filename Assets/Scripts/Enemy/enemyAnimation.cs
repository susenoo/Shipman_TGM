using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAnimation : MonoBehaviour {

    public bool playerInTrigger = false;
    public Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            playerInTrigger = true;
            anim.SetBool("Active", true);
        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == ("Player"))
        {
            playerInTrigger = false;
            anim.SetBool("Active", false);
        }
    }
}
