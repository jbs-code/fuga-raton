using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Atrapar : MonoBehaviour {

	// Use this for initialization
	//public GameObject rat, rat2;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
				if (col.gameObject.name == "ratonera" || col.gameObject.name == "ratonera(Clone)") {
						 SceneManager.LoadScene("gameOver");
				}
		}
}
