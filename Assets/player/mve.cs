using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mve : MonoBehaviour {
	public float speed=1f;
    const int Defaultlife = 100;
    public int maxHP = 100;
    const int DefaultMP = 100;
    public int maxMP = 100;
	public bool cover = true;
	public bool Left_state=false;
	public bool Right_state=false;
	public int mana_Recover=3;
	public int HP = Defaultlife;
    public int MP = DefaultMP;
    bool HellDrop_state = false;
   

	void Start()
	{
		maxHP = (int)(80f+PlayerPrefs.GetFloat ("Hp")*20);
		maxMP = (int)(80f+PlayerPrefs.GetFloat ("Mana")*20);
		mana_Recover = (int)(2f + PlayerPrefs.GetFloat ("Mana_re"));
		MP = maxMP;
		HP = maxHP;
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)||Right_state) {
            MoveRight();
		}
		if (Input.GetKey (KeyCode.LeftArrow)||Left_state) {
            MoveLeft();
		}
        if (HellDrop_state == false)
        {
            if (cover)
            {
                Invoke("Mana_cover", 2);
                MP += mana_Recover;
                if (MP > maxMP)
                {
                    MP = maxMP;
                }
                cover = false;
            }
        }
        else
        {
            Invoke("recover_HellDrop", 5f);
        }
    }

    public void use_HellDrop()
    {
        print("here2");
        HellDrop_state = true;
    }
    public void recover_HellDrop()
    {
        print("here1");
        HellDrop_state = false;
    }
    void Mana_cover()
	{
		cover = true;
	}
	public void L_state(bool state)
	{
		Left_state = state;
	}
	public void R_state(bool state)
	{
		Right_state = state;
	}
    public void UseSkill1(int Mana)
    {
        MP -= Mana;
    }
    public void UseSkill2(int Mana)
    {
        MP -= Mana;
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

	public void heal(int x)
	{
		HP += x;
		if (HP > maxHP) {
			HP = maxHP;
		}
	}

	public int getHP()
	{
		return HP;
	}
	public int getMaxHP()
	{
		return maxHP;
	}
	public int getMP()
	{
		return MP;
	}
	public int getMaxMP()
	{
		return maxMP;
	}


    void OnTriggerEnter(Collider tan)
	{
		if (tan.tag == "enemy_tan") {
			Destroy (tan.gameObject);
			HP=HP-tan.gameObject.GetComponent<enemy_tan>().getDamage();
			if (HP <= 0) {
				Destroy (this.gameObject);
			}
		}
	}
}
