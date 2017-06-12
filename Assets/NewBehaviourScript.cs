using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    void Update()
	{
		Invoke ("changeScene", 2);   
        if (Input.GetKey(KeyCode.Return))
        {
            Color _fadeColor = new Color(0f, 0f, 0f, 1f);
			reset ();
            Autofade.LoadLevel("start1 scene", 1, 1, _fadeColor);

        }
        /* 엔터키를 누르면 main 신을 불러오라는 의미 */
    }
	void changeScene()
	{
        Color _fadeColor = new Color(0f, 0f, 0f, 1f);
		reset ();
        Autofade.LoadLevel("start1 scene", 1, 1, _fadeColor);
    }
	void reset()
	{
		if (!PlayerPrefs.HasKey ("lv")) {
			PlayerPrefs.SetInt ("lv", 1);
		}
		if (!PlayerPrefs.HasKey ("exp")) {
			PlayerPrefs.SetInt ("exp", 1);
		}
		if (!PlayerPrefs.HasKey ("point")) {
			PlayerPrefs.SetInt ("point", 1);
		}
		if (!PlayerPrefs.HasKey ("Damage")) {
			PlayerPrefs.SetFloat ("Damage", 1f);
		}
		if (!PlayerPrefs.HasKey ("Max_Damage")) {
			PlayerPrefs.SetFloat ("Max_Damage", 5f);
		}
		if (!PlayerPrefs.HasKey ("attack_speed")) {
			PlayerPrefs.SetFloat ("attack_speed", 1f);
		}
		if (!PlayerPrefs.HasKey ("Max_attack_speed")) {
			PlayerPrefs.SetFloat ("Max_attack_speed", 5f);
		}
		if (!PlayerPrefs.HasKey ("tan_speed")) {
			PlayerPrefs.SetFloat ("tan_speed", 1f);
		}
		if (!PlayerPrefs.HasKey ("Mana")) {
			PlayerPrefs.SetFloat ("Mana", 1f);
		}
		if (!PlayerPrefs.HasKey ("Max_Mana")) {
			PlayerPrefs.SetFloat ("Max_Mana", 5f);
		}
		if (!PlayerPrefs.HasKey ("Mana_re")) {
			PlayerPrefs.SetFloat ("Mana_re", 1f);
		}
		if (!PlayerPrefs.HasKey ("Max_Mana_re")) {
			PlayerPrefs.SetFloat ("Max_Mana_re", 5f);
		}
		if (!PlayerPrefs.HasKey ("Hp")) {
			PlayerPrefs.SetFloat ("Hp", 1f);
		}
		if (!PlayerPrefs.HasKey ("Max_Hp")) {
			PlayerPrefs.SetFloat ("Max_Hp", 5f);
		}
		if (!PlayerPrefs.HasKey ("coin")) {
			PlayerPrefs.SetInt ("coin", 0);
		}
		if (!PlayerPrefs.HasKey ("soul")) {
			PlayerPrefs.SetInt ("soul", 0);
		}

		if (!PlayerPrefs.HasKey ("attack")) {
			PlayerPrefs.SetInt ("attack", 1);
		}
		if (!PlayerPrefs.HasKey ("defence")) {
			PlayerPrefs.SetInt ("defence", 1);
		}
		if (!PlayerPrefs.HasKey ("Meteor")) {
			PlayerPrefs.SetInt ("Metemor", 1);
		
		}
		if (!PlayerPrefs.HasKey ("Poison")) {
			PlayerPrefs.SetInt ("Poison", 1);
		}
		if (!PlayerPrefs.HasKey ("FireBall")) {
			PlayerPrefs.SetInt ("FireBall", 1);
		}
		if (!PlayerPrefs.HasKey ("IceGun")) {
			PlayerPrefs.SetInt ("IceGun", 1);
		}
		if (!PlayerPrefs.HasKey ("HellDrop")) {
			PlayerPrefs.SetInt ("HellDrop", 1);
		}
		if (!PlayerPrefs.HasKey ("Barrier")) {
			PlayerPrefs.SetInt ("Barrier", 1);
		}
		if (!PlayerPrefs.HasKey ("Shild")) {
			PlayerPrefs.SetInt ("Shild", 1);
		}
		if (!PlayerPrefs.HasKey ("Heal")) {
			PlayerPrefs.SetInt ("Heal", 1);
		}
		if (!PlayerPrefs.HasKey ("DotHeal")) {
			PlayerPrefs.SetInt ("DotHeal", 1);
		}
		if (!PlayerPrefs.HasKey ("Reflect")) {
			PlayerPrefs.SetInt ("Reflect", 1);
		}
		if (!PlayerPrefs.HasKey ("clear")) {
			PlayerPrefs.SetInt ("clear", 11);
		}
	}
}
