using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_hpbar : MonoBehaviour
{


	float max_Health;
    float cur_Health = 0f;
    public GameObject enemy_HealthBar;
    // Use this for initialization 
    void Start()
    {
		max_Health = this.gameObject.GetComponent<enemy_move> ().getMaxHP();
        cur_Health = max_Health;
    }

    // Update is called once per frame
    void Update()
    {
		decreseHealth ();
    }

    public void decreseHealth()
    {
		cur_Health=this.gameObject.GetComponent<enemy_move> ().getHP ();
        //cur_Health -= 2f;
        float calc_Health = cur_Health / max_Health;
        SetHealthBar(calc_Health);
    }

    public void SetHealthBar(float myHealth)
    {
        enemy_HealthBar.transform.localScale = new Vector3(Mathf.Clamp(myHealth, 0f, 1f), enemy_HealthBar.transform.localScale.y, enemy_HealthBar.transform.localScale.z);
    }
}

