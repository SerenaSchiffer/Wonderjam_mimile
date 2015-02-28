using UnityEngine;
using System.Collections;

public class HeroScript : MonoBehaviour {
	public bool canMove;
	public Movement mouvements;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (canMove) 
		{
			int posX = mouvements.posX;
			int posY = mouvements.posY;
			if(Input.GetAxis ("Horizontal") == 1)
			{
				mouvements.Move('d',posX,posY);
			}
		}
	}
}
