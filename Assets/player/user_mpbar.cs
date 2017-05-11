using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class user_mpbar : MonoBehaviour
{


    float max_MP;
    float cur_MP = 0f;
    public GameObject user_MPBar;
    // Use this for initialization 
    void Start()
    {
        max_MP = this.gameObject.GetComponent<mve>().getMaxMP();
        cur_MP = max_MP;
    }

    // Update is called once per frame
    void Update()
    {
        decreseMP();
    }

    public void decreseMP()
    {
        cur_MP = this.gameObject.GetComponent<mve>().getMP();
        //cur_Health -= 2f;
        float calc_Health = cur_MP / max_MP;
        SetMPBar(calc_Health);
    }

    public void SetMPBar(float myHealth)
    {
        user_MPBar.transform.localScale = new Vector3(Mathf.Clamp(myHealth, 0f, 1f), user_MPBar.transform.localScale.y, user_MPBar.transform.localScale.z);
    }
}

