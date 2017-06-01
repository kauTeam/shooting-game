using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hell_Drop : MonoBehaviour
{

    // Use this for initialization
    float Damage;
    float Speed;
    int i = 0;
    // Update is called once per frame


    void Start()
    {
        if (PlayerPrefs.HasKey("HellDrop_Damage"))
        {
            Damage = PlayerPrefs.GetFloat("HellDrop_Damage");
        }
        else
        {
            Damage = 50f;
        }
        Speed = 3f;
    }

    void HellDrop_Damage(float input_Damage)
    {
        Damage = input_Damage;
    }

    public float HellDrop_Damage()
    {
        return Damage;
    }

    void Update()
    {
        if(i%20 < 10)
        {
            this.transform.Translate(new Vector3(1, 0, 2) * Time.deltaTime * Speed);
        }
        else
        {
            this.transform.Translate(new Vector3(-1, 0, 2) * Time.deltaTime * Speed);
        }
        i++;

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
