using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	// Use this for initialization
	public GUISkin sk;
	public Texture2D textura;
	private int score;
	public bool sumar;

	void Start () {
		AudioListener.volume = PlayerPrefs.GetFloat ("Volumen");
		score = 0;
		sumar = false;
	}
	// Update is called once per frame
	void Update () {
		if (sumar) {
			score += 1;
			sumar = false;
		}
	}

	void OnGUI(){
		GUI.skin = sk;
		GUI.Label (new Rect(Screen.width/2, Screen.height/15, Screen.width/1, Screen.height/4), "x  " + score.ToString());
		GUI.Label (new Rect(Screen.width/2.57f, Screen.height/15, Screen.width/10, Screen.height/10), textura);
		PlayerPrefs.SetInt ("Score", score);
	}

}
