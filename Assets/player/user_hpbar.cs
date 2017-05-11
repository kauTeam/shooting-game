using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class user_hpbar : MonoBehaviour
{


    float max_Health;
    float cur_Health = 0f;
    public GameObject user_HPBar;
    // Use this for initialization 
    void Start()
    {
        max_Health = this.gameObject.GetComponent<mve>().getMaxHP();
        cur_Health = max_Health;
    }

    // Update is called once per frame
    void Update()
    {
        decreseHealth();
    }

    public void decreseHealth()
    {
        cur_Health = this.gameObject.GetComponent<mve>().getHP();
        //cur_Health -= 2f;
        float calc_Health = cur_Health / max_Health;
        SetHealthBar(calc_Health);
    }

    public void SetHealthBar(float myHealth)
    {
        user_HPBar.transform.localScale = new Vector3(Mathf.Clamp(myHealth, 0f, 1f), user_HPBar.transform.localScale.y, user_HPBar.transform.localScale.z);
    }
}

