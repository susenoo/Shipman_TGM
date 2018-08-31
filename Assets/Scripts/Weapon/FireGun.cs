using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour {

    public GameObject FireBulletPrefab;

    public Transform FireBulletSpawn;

    public float FireBulletSpeed = 30f;

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
        GameObject FireBullet = Instantiate(FireBulletPrefab);

        //Physics.IgnoreCollision(IceBullet.GetComponent<Collider>(),IceBulletSpawn.parent.GetComponent<Collider>());

        FireBullet.transform.position = FireBulletSpawn.position;

        Vector3 rotation = FireBullet.transform.rotation.eulerAngles;

        FireBullet.transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);

        FireBullet.GetComponent<Rigidbody>().AddForce(FireBulletSpawn.forward * FireBulletSpeed, ForceMode.Impulse);

        StartCoroutine(DestoryFireBulletAfterTime(FireBullet, lifeTime));
    }


    private IEnumerator DestoryFireBulletAfterTime(GameObject FireBullet, float delay)
    {
        yield return new WaitForSeconds(delay);

    }
}
