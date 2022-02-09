using UnityEngine;
using System.Collections;

public class Aumentar : MonoBehaviour {
	public GameObject score;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D col){
		score.GetComponent<Score> ().sumar = true;
	}
}
