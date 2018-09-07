using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour {

    public  float damage = 5;

    // Use this for initialization
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<MeleeHealth>().TakeDamage(damage);
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<MeleeHealth>().TakeDamage(damage);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
