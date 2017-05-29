using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice_Gun : MonoBehaviour
{

    // Use this for initialization
    float Damage;
    float Speed;
    // Update is called once per frame


    void Start()
    {
        if (PlayerPrefs.HasKey("IceGun_Damage"))
        {
            Damage = PlayerPrefs.GetFloat("IceGun_Damage");
        }
        else
        {
            Damage = 5f;
        }
        Speed = 15f;
    }

    void IceGun_Damage(float input_Damage)
    {
        Damage = input_Damage;
    }
    public float IceGun_Damage()
    {
        return Damage;
    }

    void Update()
    {
        this.transform.Translate(new Vector3(0, -5, 0) * Time.deltaTime * Speed);
        if (this.transform.position.y < 0.5)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider tan)
    {
        if (tan.tag == "Terrain")
        {
            Destroy(this.gameObject);
        }
    }
}
