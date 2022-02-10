using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Preferencias : MonoBehaviour {

	// Use this for initialization
	public GUISkin sk;
	private float volumen;
    private bool ver1;
    private bool ver2;

	void Start () {
		if(PlayerPrefs.HasKey("Volumen"))
			volumen = PlayerPrefs.GetFloat ("Volumen");
		else
			volumen = 1.0f;

        ver1 = true;
        ver2 = false;
	}
	// Update is called once per frame
	void Update () {
			AudioListener.volume = volumen;
	}

	void OnGUI(){
		GUI.skin = sk;

        if (ver1)
        {
            if (GUI.Button(new Rect(Screen.width / 10.0f, Screen.height / 5.0f, Screen.width / 4.0f, Screen.width / 12.0f), "Sound")) { 
                ver2 = true;
                ver1 = false;
            }

            if (GUI.Button(new Rect(Screen.width / 10.0f, Screen.height / 2.55f, Screen.width / 4.0f, Screen.width / 12.0f), "How to play"))
                 SceneManager.LoadScene("intro1");

            if (GUI.Button(new Rect(Screen.width / 10.0f, Screen.height / 1.7f, Screen.width / 4.0f, Screen.width / 12.0f), "Home"))
                 SceneManager.LoadScene("inicio");
        }

        if (ver2)
        {
            GUI.Label(new Rect(Screen.width / 3.5f, Screen.height / 10, Screen.width / 1, Screen.width / 8), "Options");
            GUI.Label(new Rect(Screen.width / 11, Screen.height / 4, Screen.width / 1, Screen.width / 8), "Sound");

            if (GUI.Button(new Rect(Screen.width / 2.6f, Screen.height / 1.5f, Screen.width / 4.0f, Screen.width / 12.0f), "Back")) {
                ver2 = false;
                ver1 = true;
            }

            if (GUI.Button(new Rect(Screen.width / 10.0f, Screen.height / 1.5f, Screen.width / 4.0f, Screen.width / 12.0f), "Home"))
                 SceneManager.LoadScene("inicio");

            volumen = GUI.HorizontalSlider(new Rect(Screen.width / 5, Screen.height / 2.5f, Screen.width / 4, Screen.height / 8), volumen, 0.0f, 1.0f);
            PlayerPrefs.SetFloat("Volumen", volumen);
        }
	}
}
