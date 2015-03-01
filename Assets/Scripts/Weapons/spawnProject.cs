using UnityEngine;
using System.Collections;

public class spawnProject : MonoBehaviour {
	public GameObject project;
	public Vector3 spawnPosition;

	public void spawnProjectile()
	{
		spawnPosition = new Vector3 (0, 0, 0);
		Instantiate (project, spawnPosition, Quaternion.identity);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
