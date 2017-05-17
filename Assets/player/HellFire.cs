﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellFire : MonoBehaviour
{

    // Use this for initialization
    float Damage;
    float Speed;
    // Update is called once per frame


    void Start()
    {
        if (PlayerPrefs.HasKey("HellFire_Damage"))
        {
            Damage = PlayerPrefs.GetFloat("HellFire_Damage");
        }
        else
        {
            Damage = 70f;
        }
        Speed = 2f;
    }

    void setHellFire_Damage(float input_Damage)
    {
        Damage = input_Damage;
    }
    public float getHellFire_Damage()
    {
        return Damage;
    }

    void Update()
    {
       this.transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * Speed);
       if (this.transform.position.y < 0)
       {
           Destroy(this.gameObject);
       }
    }
}
