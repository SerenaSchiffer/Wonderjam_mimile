using UnityEngine;
using System.Collections;

public class turn_Manager : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	public void tour(bool isHero)
    {
		if (isHero) 
		{
			HeroScript hero = GameObject.FindObjectOfType<HeroScript>();
			hero.canMove=true;
		} 

		else 
		{
			EnemyScript[] enemies = GameObject.FindObjectsOfType<EnemyScript>();
			foreach(EnemyScript enemy in enemies)
			{
                enemy.Move();
			}
			tour (true);
		}
	}

	void LateUpdate()
	{
		//Camera camera = GameObject.FindObjectOfType<Camera>();
		//camera.transform.position.y = 1.66f;
	}
}
