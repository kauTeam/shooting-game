using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enemy_move : MonoBehaviour {


	int movePoint=3;
	public float speed=5f;
	public const float MaxHp=5f;
	float life=MaxHp;
	public GameObject result = null;
	public Transform loc = null;
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
			life=life-(float)tan.gameObject.GetComponent<tan>().getDamage();
			if (life < 0) {
				Destroy (this.gameObject);	
//				SceneManager.LoadScene("2_monster");
			}
		}
	}
}
