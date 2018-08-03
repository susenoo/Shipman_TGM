using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour {

    public float LifeTime;

    // Use this for initialization
    void Start()
    {

        Destroy(gameObject, LifeTime * Time.deltaTime);



    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject)
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
