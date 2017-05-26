using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    public GameObject miss = null;
    public GameObject Poison_tan = null;
    public GameObject player = null;
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
        }
        else
        {
            damage = 30f;
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
            set_poison_time = 5f;
        }
    }
    void Update()
    {
        if (shoot_state)
        {
            if (shoot_Poison)
            {
                Invoke("set_shoot_state", attack_speed);
                GameObject tan_poison = Instantiate(Poison_tan, loc.position, loc.rotation);
                tan_poison.GetComponent<Poison>().setDamage(damage);
                tan_poison.GetComponent<Poison>().setSpeed(tan_speed * 20);
                shoot_state = false;
                poison_time += Time.deltaTime;
                if (poison_time > set_poison_time)
                {
                    shoot_Poison = false;
                    poison_time = 0;
                }
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
}
