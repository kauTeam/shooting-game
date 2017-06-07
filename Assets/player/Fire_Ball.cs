using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Ball : MonoBehaviour
{

    // Use this for initialization
    float Damage;
    float Speed;
    // Update is called once per frame


    void Start()
    {
        if (PlayerPrefs.HasKey("FireBall"))
        {
			int level=PlayerPrefs.GetInt("FireBall");
			float damage = PlayerPrefs.GetFloat ("Damage");
			Damage = 7f+level*2f+level*damage*0.7f;
        }
        else
        {
            Damage = 10f;
        }
        Speed = 6f;
    }

    void FireBall_Damage(float input_Damage)
    {
        Damage = input_Damage;
    }
    public float FireBall_Damage()
    {
        return Damage;
    }

    void Update()
    {
        this.transform.Translate(new Vector3(0, 0, 5) * Time.deltaTime * Speed);
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
