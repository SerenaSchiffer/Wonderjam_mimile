using UnityEngine;
using System.Collections;

public class HeroScript : MonoBehaviour {
	public bool canMove;
	public Movement mouvements;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (canMove) 
		{
			int posX = mouvements.posX;
			int posY = mouvements.posY;
			if(Input.GetAxis ("Horizontal") == 1)
			{
				mouvements.Move('d',posX,posY);
			}
			if(Input.GetAxis ("Horizontal") == -1)
			{
				mouvements.Move('g',posX,posY);
			}
			if(Input.GetAxis ("Vertical") == 1)
			{
				mouvements.Move('h',posX,posY);
			}
			if(Input.GetAxis ("Vertical") == -1)
			{
				mouvements.Move('b',posX,posY);
			}
		}
	}
}
