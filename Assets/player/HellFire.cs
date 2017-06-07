using System.Collections;
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
        if (PlayerPrefs.HasKey("Meteor"))
        {
			int Level = PlayerPrefs.GetInt ("Meteor");
			float damage = PlayerPrefs.GetFloat ("Damage");
			Damage =6f+Level*2f+Level*damage;
        }
        else
        {
            Damage = 14f;
        }
        Speed = 4f;
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
       if (this.transform.position.y < 3)
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
