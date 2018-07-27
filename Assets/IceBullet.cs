using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBullet : MonoBehaviour {

    public float LifeTime;

	// Use this for initialization
	void Start () {

        Destroy(gameObject, LifeTime * Time.deltaTime);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
