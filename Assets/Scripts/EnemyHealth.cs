using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public float Health = 100f;
    

    // Use this for initialization

public void RemoveHealth(float amount)
    {
        Health -= amount;
        if (Health == 0);
        {
            Destroy(this.gameObject);
        }
    }
    

    void Start () {

        
        


		
	}
	
	// Update is called once per frame
	void Update () {
        
       
        
		
	}

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "IceBullet")
        {
            Health = Health - 10f;
        }
        if(col.gameObject.tag == "Enemy")
        {
            if (Health == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
