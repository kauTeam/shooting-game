using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enemy_move : MonoBehaviour {


	int movePoint=3;
	public float speed=5f;
	public const float MaxHp=20f;
	float life=MaxHp;
    float poison_damage;
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
	void Update () {
		if (this.transform.position.x >movePoint+1||this.transform.position.x <movePoint-1) {
			if (this.transform.position.x > movePoint) {
				this.transform.Translate (new Vector3 (1, 0, 0) * -1 * speed * Time.deltaTime);
			}
			if (this.transform.position.x < movePoint) {
				this.transform.Translate (new Vector3 (1, 0, 0) * speed * Time.deltaTime);
			}
		} else {
			movePoint = Random.Range (-15,15);
		}
	}

	void OnTriggerEnter(Collider tan)
	{
		if (tan.tag == "user_tan") {
			Destroy (tan.gameObject);
			life=life-tan.gameObject.GetComponent<tan>().getDamage();
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
        if (life < 0)
        {
            Destroy(this.gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
			int coin = PlayerPrefs.GetInt ("coin");
			PlayerPrefs.SetInt ("coin", coin + (int)MaxHp);
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
