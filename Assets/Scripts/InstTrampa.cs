using UnityEngine;
using System.Collections;

public class InstTrampa : MonoBehaviour {
	public GameObject trampa;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("InsTrampa", 1.0f, 0.6f);
	}
	// Update is called once per frame+

	void Update () {
		GetComponent<Transform> ().localPosition += new Vector3(0.03f, 0, 0);
	}
	void InsTrampa(){
		float y = Random.Range (-2.4f, -3.2f);
		Instantiate(trampa,new Vector3(this.transform.position.x, y, 0),this.transform.rotation);
	}

}
