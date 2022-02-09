using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

	// Use this for initialization
	public GameObject menu;
	public GUISkin sk;
    public bool pause;

	void Start () {
        pause = false;
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.skin = sk;
		if (GUI.Button (new Rect (Screen.width / 1.5f, Screen.height / 10, Screen.width / 5.5f, Screen.height / 10), "pause")) {
            //menu.GetComponent<Score>().activar = true;
            Time.timeScale = 0;
            GetComponent<AudioSource>().Pause(); 
            pause = true;
		}

        if (pause)
        {
            if (GUI.Button(new Rect(Screen.width / 1.5f, Screen.height / 2, Screen.width / 4.0f, Screen.width / 12.0f), "Jugar"))
            {
                 SceneManager.LoadScene("escena1");
                Time.timeScale = 1;
                GetComponent<AudioSource>().Play();
                pause = false;
            }
            if (GUI.Button(new Rect(Screen.width / 8.0f, Screen.height / 2, Screen.width / 4.0f, Screen.width / 12.0f), "Inicio"))
                 SceneManager.LoadScene("inicio");
        }
    }
}
