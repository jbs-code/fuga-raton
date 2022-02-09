using UnityEngine;
using System.Collections;

public class IdeLugar : MonoBehaviour {
	// Use this for initialization
	Vector3 pos;
	public GameObject identificar; 
	void Start () {
		pos = identificar.transform.localPosition;
		transform.localPosition = pos;
	}
	// Update is called once per frame
	void Update () {

	}
}
