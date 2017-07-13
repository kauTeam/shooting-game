using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enemy_move : MonoBehaviour {

    Animator ani=null;
    int condition = 0;
	int movePoint=3;
	public float speed=5f;
	public float MaxHp=20f;
	float life;
    float poison_damage;
    float FireBall_Damage;
    float IceGun_Damage;
    float HellDrop_Damage;
	public GameObject result = null;
    public Transform loc = null;
    public ParticleSystem explosion;
    public int check_Poison_count = 0; 
    // Update is called once per frame
    public float getHP()
	{
		return life;
	}
	public float getMaxHP()
	{
		return MaxHp;
	}
	void Start()
	{
        ani = gameObject.GetComponent<Animator>();
		life = MaxHp;
	}

	void Update () {
        if (this.transform.position.x >movePoint+1||this.transform.position.x <movePoint-1) {
			if (this.transform.position.x > movePoint) {
				this.transform.Translate (new Vector3 (1, 0, 0) * -1 * speed * Time.deltaTime);
			}
			if (this.transform.position.x < movePoint) {
				this.transform.Translate
				(new Vector3 (1, 0, 0) * speed * Time.deltaTime);
			}
		} else {
			movePoint = Random.Range (-15,15);
		}
	}

    void back_speed()
    {
        speed = 5f;
    }

	void OnTriggerEnter(Collider tan)
	{
		if (tan.tag == "user_tan") {
			Destroy (tan.gameObject);
            ani.SetTrigger("damage");
            life =life-tan.gameObject.GetComponent<tan>().getDamage();
//			if (life < 0) {
//				Destroy (this.gameObject);
//                Instantiate(explosion, transform.position, Quaternion.identity);	
////				SceneManager.LoadScene("2_monster");
//			}
		}
        if (tan.tag == "HellFire")
        {
            Destroy(tan.gameObject);
            life = life - tan.gameObject.GetComponent<HellFire>().getHellFire_Damage();
            //if (life < 0)
            //{
            //    Destroy(this.gameObject);
            //    Instantiate(explosion, transform.position, Quaternion.identity);
            //    //				
            //    //				SceneManager.LoadScene("2_monster");
            //}
        }
        if(tan.tag == "Poison_tan")
        {
            Destroy(tan.gameObject);
            poison_damage = tan.gameObject.GetComponent<Poison>().getDamage();
            life = life - poison_damage;
            check_Poison_count = 0;
            Invoke("hit_Poison_tan", 1f);
        }
        if(tan.tag == "Fire_Ball")
        {
            Destroy(tan.gameObject);
            FireBall_Damage = tan.gameObject.GetComponent<Fire_Ball>().FireBall_Damage();
            life -= FireBall_Damage;

        }
        if (tan.tag == "Ice_Gun")
        {
            Destroy(tan.gameObject);
            IceGun_Damage = tan.gameObject.GetComponent<Ice_Gun>().IceGun_Damage();
            life -= IceGun_Damage;
            speed = 2f;
            Invoke("back_speed", 2f);
            
        }
        if (tan.tag == "Hell_Drop")
        {
            Destroy(tan.gameObject);
            HellDrop_Damage = tan.gameObject.GetComponent<Hell_Drop>().HellDrop_Damage();
            life -= HellDrop_Damage;
        }
        if (life < 0)
        {
            Destroy(this.gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
			int coin = PlayerPrefs.GetInt ("coin");
			PlayerPrefs.SetInt ("coin", coin + (int)MaxHp);
			int get_coin=PlayerPrefs.GetInt ("get_coin");
			PlayerPrefs.SetInt ("get_coin", get_coin + (int)MaxHp);
			//				
            //				SceneManager.LoadScene("2_monster");
        }
    }

    void hit_Poison_tan()
    {
        life -= poison_damage;
        if (check_Poison_count < 1)
        {
            check_Poison_count++;
            Invoke("hit_Poison_tan", 1f);
        }
        else
            check_Poison_count = 0;
    }
        
}
