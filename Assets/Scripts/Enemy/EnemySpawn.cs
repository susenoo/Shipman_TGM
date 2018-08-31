using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject Enemy;
    public Transform EnemyPos;
    public Transform EnemyPos01;
    public Transform EnemyPos02;
    public float RepeatRate = 5f;

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            InvokeRepeating("EnemySpawner", 0.5f, RepeatRate);
            Destroy(gameObject, 11);
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    void EnemySpawner()
    {
        GameObject _newEnemy01 =  Instantiate(Enemy, EnemyPos.position, EnemyPos.rotation);

        GameObject _newEnemy02 = Instantiate(Enemy, EnemyPos01.position, EnemyPos01.rotation);

        Instantiate(Enemy, EnemyPos02.position, EnemyPos02.rotation);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
