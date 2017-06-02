using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class result_button_control : MonoBehaviour {


    Color _fadeColor = new Color(0f, 0f, 0f, 1f);

#if UNITY_EDITOR
    public UnityEngine.Object next;
	public UnityEngine.Object now;
	public UnityEngine.Object level_select;
#endif

    [HideInInspector]
    [SerializeField]
    string sceneName1 = "";
	string sceneName2 = "";
	string sceneName3 = "";

#if UNITY_EDITOR
    public void OnValidate()
    {
        sceneName1 = "";

		if (next != null)
        {
			if (next.ToString().Contains("(UnityEngine.SceneAsset)"))
            {
				sceneName1 = next.name;
            }
            else
            {
				next = null;
            }
        }

		sceneName2 = "";

		if (now != null)
		{
			if (now.ToString().Contains("(UnityEngine.SceneAsset)"))
			{
				sceneName2 = now.name;
			}
			else
			{
				now = null;
			}
		}

		sceneName3 = "";

		if (level_select != null)
		{
			if (level_select.ToString().Contains("(UnityEngine.SceneAsset)"))
			{
				sceneName3 = level_select.name;
			}
			else
			{
				level_select = null;
			}
		}
    }
#endif

    // Use this for initialization
	public void load_next()
	{
		print ("scene/"+sceneName1);
        Autofade.LoadLevel("scene/Round1/"+sceneName1, 1, 1, _fadeColor);
    }
	public void load_lv_select()
	{
		print ("scene/"+sceneName3);
        Autofade.LoadLevel("scene/"+sceneName3, 1, 1, _fadeColor);
    }
	public void load_now()
	{
		print ("scene/"+sceneName2);
        Autofade.LoadLevel("scene/Round1/" + sceneName2, 1, 1, _fadeColor);
    }
}
