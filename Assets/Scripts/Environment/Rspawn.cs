using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rspawn : MonoBehaviour {

    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint01;
   // [SerializeField] private Transform respawnPoint02;
    //[SerializeField] private Transform respawnPoint03;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.localPosition = respawnPoint01.transform.position;
        //Player.transform.localPosition = respawnPoint02.transform.position;
        //Player.transform.localPosition = respawnPoint03.transform.position;
    }
}
