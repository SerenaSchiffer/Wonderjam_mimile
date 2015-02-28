using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LateUpdate()
	{
		this.transform.position = new Vector3 (GameObject.FindObjectOfType<HeroScript> ().transform.position.x, 0.544f,-10f);
	}
}
