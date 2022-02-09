using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Intro1 : MonoBehaviour {

    // Use this for initialization

    private float time;

	void Start () {
        time = 0.0f;
        InvokeRepeating("Tiempo", 0.0f, 1.0f);
    }
	
	// Update is called once per frame
	void Update () {
        if (time == 5.0f) {
             SceneManager.LoadScene("intro2");
        }
	}

    void Tiempo() {
        time += 1.0f;
    }
}
