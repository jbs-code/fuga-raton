using UnityEngine;
using System.Collections;

public class MovBackground : MonoBehaviour {

	// Use this for initialization
	public GameObject posicion;
	public GameObject fondo;
	private float time;

	void Start () {
		time = 0.05f;
		InvokeRepeating("Tiempo", 1.0f, 1.0f);
	}
	
	// Update is called once per frame
	
	void FixedUpdate () {
		GetComponent<Transform> ().localPosition += new Vector3(time, 0, 0) * -1;	
		Vector3 screenPos = Camera.main.GetComponent<Camera>().WorldToScreenPoint(fondo.transform.localPosition);
		
		if (screenPos.x < -800f)
			transform.localPosition = new Vector3 (posicion.transform.localPosition.x, transform.localPosition.y, posicion.transform.localPosition.z);
	}
	void Tiempo(){
		time += 0.01f;
	}
}
