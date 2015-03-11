using UnityEngine;
using System.Collections;

public class ClickDetector : MonoBehaviour {
	
	public GameObject pointer;

	public AudioClip sound1;

	// Use this for initialization
	void Start () {
		Debug.Log("enrico start");
	}

	void Update() {
		if (Input.GetButtonDown("Fire1") || Input.touchCount > 0) {

			Debug.Log("x:" + Input.mousePosition.x);
			Debug.Log("y:" + Input.mousePosition.y);

//			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//			if (Physics.Raycast(ray))
//				Instantiate(particle, transform.position, transform.rotation) as GameObject;

			Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			pz.z = 0;
			pointer.transform.position = pz;

			AudioSource.PlayClipAtPoint(sound1, Camera.main.transform.position);
		}
	}
}
