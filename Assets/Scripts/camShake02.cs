﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camShake02 : MonoBehaviour {

    public Animator CamAnim;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CamShake()
    {
        CamAnim.SetTrigger("shake");
    }
}
