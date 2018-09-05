using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeleeHealth : MonoBehaviour {

    public Image EnemyHealth;
    public float maxHealth = 100f;
    public float currentHealth = 0f;
    public bool alive = true;

    // Use this for initialization
    void Start () {

        alive = true;
        currentHealth = maxHealth;
        SetHealthBar();

    }

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
            //gameObject.SetActive(false);
        }
        currentHealth -= amount;
        SetHealthBar();
    }

    public void SetHealthBar()
    {
        float myHealth = currentHealth / maxHealth;
        EnemyHealth.transform.localScale = new Vector3(Mathf.Clamp(myHealth, 0f, 1f), EnemyHealth.transform.localScale.y, EnemyHealth.transform.localScale.z);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
