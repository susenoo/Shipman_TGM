using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShockGun : MonoBehaviour {

    public GameObject ShockBulletPrefab;

    public Transform ShockBulletSpawn;

    public float ShockBulletSpeed = 30f;

    public float lifeTime = 3f;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
    }

    private void Fire()
    {
        GameObject IceBullet = Instantiate(ShockBulletPrefab);

        //Physics.IgnoreCollision(IceBullet.GetComponent<Collider>(),IceBulletSpawn.parent.GetComponent<Collider>());

        IceBullet.transform.position = ShockBulletSpawn.position;

        Vector3 rotation = IceBullet.transform.rotation.eulerAngles;

        IceBullet.transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);

        IceBullet.GetComponent<Rigidbody>().AddForce(ShockBulletSpawn.forward * ShockBulletSpeed, ForceMode.Impulse);

        StartCoroutine(DestoryIceBulletAfterTime(IceBullet, lifeTime));
    }


    private IEnumerator DestoryIceBulletAfterTime(GameObject IceBullet, float delay)
    {
        yield return new WaitForSeconds(delay);

    }
}
