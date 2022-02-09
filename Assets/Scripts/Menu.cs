using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	public GUISkin sk; 
	void Start () {
		AudioListener.volume = PlayerPrefs.GetFloat ("Volumen");
	}

	// Update is called once per frame
	void Update () {

	}
	void OnGUI(){
		GUI.skin = sk;

        if (GUI.Button(new Rect(Screen.width / 1.4f, Screen.height / 1.25f, Screen.width / 5.0f, Screen.width / 12.0f), "Salir"))
            Application.Quit();
        if (GUI.Button (new Rect (Screen.width / 1.95f, Screen.height/1.25f, Screen.width / 5.0f, Screen.width / 12.0f), "Ayuda"))
			 SceneManager.LoadScene("preferencias");
		if (GUI.Button (new Rect (Screen.width / 3.3f, Screen.height/1.25f, Screen.width / 5.0f, Screen.width / 12.0f), "Puntuación"))
			 SceneManager.LoadScene("score");
		if (GUI.Button (new Rect (Screen.width / 10.0f, Screen.height/1.25f, Screen.width / 5.0f, Screen.width / 12.0f), "Jugar"))
			 SceneManager.LoadScene("escena1");
   }
}
