using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tan : MonoBehaviour {

	float destroy_pos = 25f;
	public float speed;
	float damage;

	// Update is called once per frame
	public void setDamage(float x)
	{
		damage = x;
	}
	public void setSpeed(float x)
	{
		speed = x;
	}
	public float getDamage()
	{
		return damage;
	}
	void Update () {
		this.transform.Translate(new Vector3 (0, 0, 1) * Time.deltaTime * speed);
		if (this.transform.position.z > destroy_pos) {
			Destroy (this.gameObject);
		}
	}
}
