using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceGun2 : MonoBehaviour {

    public float moveForce = 0f;
    private Rigidbody rbody;
    public GameObject IceBullet;
    public Transform IceGunSpawn;
    public float shootRate = 0f;
    public float shootForce = 0f;
    private float shootRateTimeStamp = 0f;


	// Use this for initialization
	void Start () {

        rbody = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {

        float h = Input.GetAxisRaw("Horizontal") * moveForce;
        float v = Input.GetAxisRaw("Vertical") * moveForce;

        rbody.velocity = new Vector3(h, v, 0);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(Time.time > shootRateTimeStamp)
            {
                GameObject go = (GameObject)Instantiate(
                    IceBullet, IceGunSpawn.position, IceGunSpawn.rotation);
                go.GetComponent<Rigidbody>().AddForce(IceGunSpawn.forward * shootForce);
                shootRateTimeStamp = Time.time + shootRate;
            }
        }

    }
}
