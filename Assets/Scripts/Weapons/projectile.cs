using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour {
	public Vector2 direction;
	// Use this for initialization

	void Start () {
		Debug.Log("je suis dans le start");

		Vector2 direction = new Vector2(1, 0);
	}
	public void setDirection( int direct) {
		if(direct==1){
			Vector2 direction = new Vector2(1, 0);
		}
		else{
			Vector2 direction = new Vector2(-1, 0);
		}
	}
	// Update is called once per frame
	public Vector2 speed = new Vector2(1, 1);
	


	
	private Vector2 movement;
	
	void Update()
	{
		// 2 - Movement
		movement = new Vector2(
			speed.x * direction.x,
			speed.y * direction.y);
	}
	void FixedUpdate()
	{
		// Apply movement to the rigidbody
		//rigidbody2D.velocity = movement;
	}
	void OnCollisionEnter2D()
	{
		//Destroy(gameObject);
	}
}
