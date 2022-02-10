using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	public GUISkin sk;

	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnGUI(){
		GUI.skin = sk;
		if (GUI.Button (new Rect (Screen.width / 1.5f, Screen.height/1.25f, Screen.width / 4.0f, Screen.width / 12.0f), "Play"))
			 SceneManager.LoadScene("escena1");
		if (GUI.Button (new Rect (Screen.width / 8.0f, Screen.height/1.25f, Screen.width / 4.0f, Screen.width / 12.0f), "Home"))
			 SceneManager.LoadScene("inicio");
	}
}
