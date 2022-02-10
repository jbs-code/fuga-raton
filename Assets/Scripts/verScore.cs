using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class verScore : MonoBehaviour {

	// Use this for initialization
	public GUISkin sk;
	public Texture2D textura;
	private int score, scoreMayor;
	void Start () {
		AudioListener.volume = PlayerPrefs.GetFloat ("Volumen");

		scoreMayor = PlayerPrefs.GetInt ("ScoreOficial");
		score = PlayerPrefs.GetInt ("Score");
	}
	// Update is called once per frame
	void Update () {

		if(scoreMayor < score)
			scoreMayor = PlayerPrefs.GetInt("Score");
	}

	void OnGUI(){
		GUI.skin = sk;
		GUI.Label (new Rect(Screen.width/10, Screen.height/10, Screen.width/1, Screen.height/4.0f), "Best Score");
		GUI.Label (new Rect(Screen.width/3.5f, Screen.height/4, Screen.width/1, Screen.height/6), "X  "+ scoreMayor.ToString());
		GUI.Label (new Rect(Screen.width/6, Screen.height/4, Screen.width/10, Screen.width/10), textura);
		PlayerPrefs.SetInt ("ScoreOficial", scoreMayor);

		if (GUI.Button (new Rect (Screen.width / 8.0f, Screen.height/1.25f, Screen.width / 4.0f, Screen.width / 12.0f), "Home"))
			 SceneManager.LoadScene("inicio");
	}
}
