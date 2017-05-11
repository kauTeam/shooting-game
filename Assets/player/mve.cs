using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mve : MonoBehaviour {
	public float speed=1f;
    const int Defaultlife = 5;
	public int life = Defaultlife;
    public int getLife()
    {
        return life;
    }
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
            MoveRight();
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
            MoveLeft();
		}
	}
    public void MoveLeft()
	{
		if (this.transform.localPosition.x > -13) {
			this.transform.Translate (new Vector3 (1, 0, 0) * speed * -1 * Time.deltaTime);
		}
	}
    public void MoveRight()
    {
		if (this.transform.localPosition.x < 13) {
			this.transform.Translate (new Vector3 (1, 0, 0) * speed * Time.deltaTime);
		}
    }


    void OnTriggerEnter(Collider tan)
	{
		if (tan.tag == "enemy_tan") {
			Destroy (tan.gameObject);
			life=life-tan.gameObject.GetComponent<enemy_tan>().getDamage();
			if (life <= 0) {
				Destroy (this.gameObject);
			}
		}
	}
}
