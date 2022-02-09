using UnityEngine;
using System.Collections;

public class ActRatonera : MonoBehaviour {

	// Use this for initialization
	private float time;
	private BoxCollider2D presionar; 
	private bool presiono;
	void Start () {
		presiono = false;
		time = 0.05f;
		InvokeRepeating("Tiempo", 1.0f, 1.0f);
		presionar = GetComponent<BoxCollider2D>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		GetComponent<Transform> ().localPosition += new Vector3(time, 0, 0) * -1;
		if (Input.GetMouseButtonDown(0)) {
			//Vector3 posicionTap = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			Vector3 posicionTap = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector2 posicionTap2D = new Vector2 (posicionTap.x, posicionTap.y);
			presiono = presionar.OverlapPoint (posicionTap2D);

			if (presiono) {
				GetComponent<Rigidbody2D> ().isKinematic = false;
				GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 500));
				(GetComponent<Animator> ()).SetBool ("activar", true);
				GetComponent<SpriteRenderer> ().sortingLayerName = "FueraTrampa";
				GetComponent<Rigidbody2D> ().gravityScale = 1;
				GetComponent<AudioSource>().Play();
			}
		}

		if (Input.touchCount > 0) {
			Vector3 posicionTapTouch = Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position);
			Vector2 posicionTap2DTouch = new Vector2 (posicionTapTouch.x, posicionTapTouch.y);
			presiono = presionar.OverlapPoint (posicionTap2DTouch);
			if (presiono) {
				GetComponent<Rigidbody2D> ().isKinematic = false;
				GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, 500));
				(GetComponent<Animator> ()).SetBool ("activar", true);
				GetComponent<SpriteRenderer> ().sortingLayerName = "FueraTrampa";
				GetComponent<Rigidbody2D> ().gravityScale = 1;
				GetComponent<AudioSource> ().Play ();
			}
		}
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "ratonera" || col.gameObject.name == "ratonera(Clone)") {
			GetComponent<Rigidbody2D> ().isKinematic = false;
			GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, 500));
			(GetComponent<Animator> ()).SetBool ("activar", true);
			GetComponent<SpriteRenderer> ().sortingLayerName = "FueraTrampa";
			GetComponent<Rigidbody2D> ().gravityScale = 1;
			GetComponent<AudioSource>().Play();
		}
	}

	void Tiempo(){
		time += 0.03f;
	}
}

	
  