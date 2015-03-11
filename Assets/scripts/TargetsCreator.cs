using UnityEngine;
using System.Collections;

public class TargetsCreator : MonoBehaviour {

	public GameObject brick;

	// Use this for initialization
	void Start () {
			for (int x = -5; x < 5; x++) {
				Instantiate(brick, new Vector3(x, 0, 0), Quaternion.identity);
			}
	}
	 
	// Update is called once per frame
	void Update () {
	
	}
}
