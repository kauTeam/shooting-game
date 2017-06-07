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
            damage = 2f+PlayerPrefs.GetFloat("Damage");
        }
        else
        {
            damage = 10f;
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
            tan_speed = 1f;
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
            if (shoot_Poison)
            {
                Invoke("set_shoot_state", attack_speed);
                Invoke("set_Poison_state1", 3f);
                GameObject tan = Instantiate(Poison, loc.position, loc.rotation);
				float d = 1f + PlayerPrefs.GetInt ("Poison") * 0.5f + PlayerPrefs.GetInt ("Poison") * PlayerPrefs.GetFloat ("Damage") * 0.6f;
				tan.gameObject.GetComponent<Poison> ().setDamage (d);
                tan.gameObject.GetComponent<Poison>().setSpeed(21+tan_speed);
                shoot_state = false;
                
            }
            else
            {
                Invoke("set_shoot_state", attack_speed);
                GameObject tan1 = Instantiate(miss, loc.position, loc.rotation);
                tan1.GetComponent<tan>().setDamage(damage);
				tan1.GetComponent<tan>().setSpeed(21+tan_speed);
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
