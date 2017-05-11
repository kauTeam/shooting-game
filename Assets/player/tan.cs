using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tan : MonoBehaviour {

	public float destroy_pos = 10f;
	public float speed = 20f;
	int damage=1;

	// Update is called once per frame
	public void setDamage(int x)
	{
		damage = x;
	}
	public void setSpeed(float x)
	{
		speed = x;
	}
	public int getDamage()
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
