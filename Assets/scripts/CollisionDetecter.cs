using UnityEngine;
using System.Collections;

public class CollisionDetecter : MonoBehaviour {

	public AudioClip sound1;

	// Use this for initialization
	void Start () {
		Debug.Log("instantiating collision detecter");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col) {
		Debug.Log("collision!");
		Debug.Log(col.collider.name);
		if (col.collider.name == "Sphere") {
			Destroy(gameObject);
			AudioSource.PlayClipAtPoint(sound1, Camera.main.transform.position);
		}

	}
}
