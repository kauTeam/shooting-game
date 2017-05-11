using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_tan : MonoBehaviour {
	float speed=10f;
	int type=1;
	int damage = 1;
	public void setType(int x)
	{
		type = x;
	}
	public void setSpeed(int x)
	{
		speed = (float)x;
	}
	public int getDamage()
	{
		return damage;
	}
	public void setDamage(int x)
	{
		damage = x;
	}
	public void setScale(float x, float y, float z)
	{
		this.transform.localScale+= new Vector3 (x, y, z);
	}
	void Update () {
		if (type == 1) {
			this.transform.Translate (new Vector3 (0, 0, -1) * speed * Time.deltaTime);
		}
		if (type == 2) {
			this.transform.Translate (new Vector3 (-0.5f, 0, -1) * speed * Time.deltaTime);
		}
		if (type == 3) {
			this.transform.Translate (new Vector3 (0.5f, 0, -1) * speed * Time.deltaTime);
		}
		if (type == 4) {
			this.transform.Translate (new Vector3 (1, 0, -1) * speed * Time.deltaTime);
		}
		if (type == 5) {
			this.transform.Translate (new Vector3 (-1, 0, -1) * speed * Time.deltaTime);
		}
		if (type == 6) {
			if (this.transform.position.z >10) {
				this.transform.Translate (new Vector3 (0, 0, -1) * speed * Time.deltaTime);
			} else {
				this.transform.Translate (new Vector3 (1, 0, -1) * speed * Time.deltaTime);
			}
		}
		if (type == 7) {
			if (this.transform.position.z >10) {
				this.transform.Translate (new Vector3 (0, 0, -1) * speed * Time.deltaTime);
			} else {
				this.transform.Translate (new Vector3 (-1, 0, -1) * speed * Time.deltaTime);
			}
		}
		if (type == 8) {
			if (this.transform.position.z <10) {
				this.transform.Translate (new Vector3 (0, 0, -1) * speed * Time.deltaTime);
			} else {
				this.transform.Translate (new Vector3 (1, 0, -1) * speed * Time.deltaTime);
			}
		}
		if (type == 9) {
			if (this.transform.position.z <10) {
				this.transform.Translate (new Vector3 (0, 0, -1) * speed * Time.deltaTime);
			} else {
				this.transform.Translate (new Vector3 (-1, 0, -1) * speed * Time.deltaTime);
			}
		}
		if (this.transform.position.z < -20||this.transform.position.x< -10||this.transform.position.x > 10) {
			Destroy (this.gameObject);
		}
	}
}
	