using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public Image healthBar;
    public float maxHealth = 100f;
    public float currentHealth = 0f;
    public bool alive = true;

	// Use this for initialization
	void Start () {

        alive = true;
        currentHealth = maxHealth;
        SetHealthBar();
        //InvokeRepeating("PoisonDamage", 1f, 1f);
		
	}
    
        public void PoisonDamage()
        {
            TakeDamage(3f);
        }
    /*    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Poison")
        {
            InvokeRepeating("PoisonDamage", 1f, 1f);
        }
    }
    */
    public void TakeDamage(float amount)
    {
        if (!alive)
        {
            return;
        }

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            alive = false;
            gameObject.SetActive(false);
            Application.LoadLevel(Application.loadedLevel);
        }
        currentHealth -= amount;
        SetHealthBar();

    }

    public void SetHealthBar()
    {
        float myHealth = currentHealth / maxHealth;
        healthBar.transform.localScale = new Vector3(Mathf.Clamp(myHealth, 0f, 1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
