using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthBar : MonoBehaviour {

    public Image currentHealthBar;
    public Text ratioText;

    private float hitPoint = 100;
    private float maxHitPoint = 100;

	// Use this for initialization
	void Start () {
        UpdateHealthBar();

    }

    private void UpdateHealthBar()
    {
        float ratio = hitPoint / maxHitPoint;
        currentHealthBar.rectTransform.localScale = new Vector3(ratio,1,1);
        ratioText.text = (ratio*100).ToString() + '%';

    }

    private void TakeDamage(float damage)
    {
        hitPoint -= damage;
        if (hitPoint < 0)
            Debug.Log("Dead");
        UpdateHealthBar();
    }

    private void HealDamage(float heal)
    {
        hitPoint += heal;
        if (hitPoint > maxHitPoint)
            hitPoint = maxHitPoint;
        UpdateHealthBar();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
