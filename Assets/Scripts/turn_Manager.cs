using UnityEngine;
using System.Collections;

public class turn_Manager : MonoBehaviour {

	public HeroScript hero;
	public bool Ishero;


	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	public void tour()
	{
		if (Ishero) 
		{
			hero.canMove = true;
		} 

		else 
		{

		}
	}

		
		
		

}
