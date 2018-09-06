﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class IceGun : MonoBehaviour {

    public GameObject IceBulletPrefab;
    public Transform IceBulletSpawn;
    public float IceBulletSpeed = 30f;
    public float lifeTime = 3f;

    public camShake camShake;


    

	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
            //CameraShaker.Instance.ShakeOnce(1f, 1f, .1f, 1f);
            camShake = GetComponent<camShake>();
            
        }
	}

    private void Fire()
    {
        GameObject IceBullet = Instantiate(IceBulletPrefab);

        //Physics.IgnoreCollision(IceBullet.GetComponent<Collider>(),IceBulletSpawn.parent.GetComponent<Collider>());

        IceBullet.transform.position = IceBulletSpawn.position;

        Vector3 rotation = IceBullet.transform.rotation.eulerAngles;

        IceBullet.transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);

        IceBullet.GetComponent<Rigidbody>().AddForce(IceBulletSpawn.forward * IceBulletSpeed, ForceMode.Impulse);

        StartCoroutine(DestoryIceBulletAfterTime(IceBullet, lifeTime));
    }


    private IEnumerator DestoryIceBulletAfterTime(GameObject IceBullet, float delay)
    {
        yield return new WaitForSeconds(delay);

    }
}
