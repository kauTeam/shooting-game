using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    public GameObject miss = null;
    public GameObject Poison = null;
    public Transform loc = null;
    public float attack_speed;
    public float damage;
    public float tan_speed;
    bool shoot_state = true;
    bool shoot_Poison = false;
    public float poison_time = 0;
    public float set_poison_time;

    // Update is called once per frame
    void Start()
    {
        if (PlayerPrefs.HasKey("Damage"))
        {
            damage = PlayerPrefs.GetFloat("Damage");
            damage = 5f;
        }
        else
        {
            damage = 5f;
        }
        if (PlayerPrefs.HasKey("attack_speed"))
        {
            attack_speed = 1.5f - (PlayerPrefs.GetFloat("attack_speed") * 0.1f);
        }
        else
        {
            attack_speed = 1f;
        }
        if (PlayerPrefs.HasKey("tan_speed"))
        {
            tan_speed = PlayerPrefs.GetFloat("tan_speed");
        }
        else
        {
            tan_speed = 20f;
        }
        if (PlayerPrefs.HasKey("Poison_Time"))
        {
            set_poison_time = PlayerPrefs.GetFloat("Poison_Time");
        }
        else
        {
            set_poison_time = 0.1f;
        }
    }
    void Update()
    {
        if (shoot_state)
        {
            print(shoot_Poison);
            if (shoot_Poison)
            {
                Invoke("set_shoot_state", attack_speed);
                Invoke("set_Poison_state1", 20f);
                GameObject tan = Instantiate(Poison, loc.position, loc.rotation);
                tan.gameObject.GetComponent<Poison>().setDamage(damage);
                tan.gameObject.GetComponent<Poison>().setSpeed(tan_speed*20);
                shoot_state = false;
                
            }
            else
            {
                Invoke("set_shoot_state", attack_speed);
                GameObject tan1 = Instantiate(miss, loc.position, loc.rotation);
                tan1.GetComponent<tan>().setDamage(damage);
                tan1.GetComponent<tan>().setSpeed(tan_speed * 20);
                shoot_state = false;
            }
        }


    }
    void set_shoot_state()
    {
        shoot_state = true;
    }
    public void set_Poison_state()
    {
        shoot_Poison = true;
    }
    public void set_Poison_state1()
    {
        shoot_Poison = false;
    }
}
