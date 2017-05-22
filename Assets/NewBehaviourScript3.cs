using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewBehaviourScript3 : MonoBehaviour {

    public void gotoDungeon()
    {
		SceneManager.LoadScene("scene/2_monster");
    }
    public void gotoDungeon2()
    {
        SceneManager.LoadScene("scene/1_monster");
    }
    public void gotoTraining()
    {
        SceneManager.LoadScene("scene/Training");
    }
    public void gotoState()
    {
        SceneManager.LoadScene("scene/states");
    }
    public void returnMain()
    {
        SceneManager.LoadScene("scene/main scene");
    }
	public void reset()
	{
		PlayerPrefs.SetInt ("lv",1);
		PlayerPrefs.SetInt ("exp", 1);
		PlayerPrefs.SetInt ("point", 1);

		PlayerPrefs.SetFloat ("Damage", 1f);
		PlayerPrefs.SetFloat ("Max_Damage", 5f);
		PlayerPrefs.SetFloat ("attack_speed", 1f);
		PlayerPrefs.SetFloat ("Max_attack_speed", 5f);
		PlayerPrefs.SetFloat ("Mana", 1f);
		PlayerPrefs.SetFloat ("Max_Mana", 5f);
		PlayerPrefs.SetFloat ("Mana_re", 1f);
		PlayerPrefs.SetFloat ("Max_Mana_re", 5f);
		PlayerPrefs.SetFloat ("Hp", 1f);
		PlayerPrefs.SetFloat ("Max_Hp", 5f);

		PlayerPrefs.SetInt ("coin", 1000);
		PlayerPrefs.SetInt ("soul", 0);

		PlayerPrefs.SetInt ("attack", 1);
		PlayerPrefs.SetInt ("defence", 1);

		PlayerPrefs.SetInt ("Metemor", 1);
		PlayerPrefs.SetInt ("Poison", 1);
		PlayerPrefs.SetInt ("FireBall", 1);
		PlayerPrefs.SetInt ("IceGun", 1);
		PlayerPrefs.SetInt ("HellDrop", 1);

		PlayerPrefs.SetInt ("Barrier", 1);
		PlayerPrefs.SetInt ("Shild", 1);
		PlayerPrefs.SetInt ("Heal", 1);
		PlayerPrefs.SetInt ("DotHeal", 1);
		PlayerPrefs.SetInt ("Reflect", 1);

	}
}
