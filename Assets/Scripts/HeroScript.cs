using UnityEngine;
using System.Collections;

public class HeroScript : MonoBehaviour {
	public bool canMove;
	public Movement mouvements;
	//public GameObject scriptCountainer;
	// Use this for initialization
	void Start () {

	}

	void Update() {
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
				canMove=false;
				turn.tour_Hero();

			}
			if(Input.GetAxis ("Horizontal") == -1)
			{
				mouvements.Move('g',posX,posY);
				canMove=false;
				turn.tour_Hero();
			}
			if(Input.GetAxis ("Vertical") == 1)
			{
				mouvements.Move('h',posX,posY);
				canMove=false;
				turn.tour_Hero();
			}
			if(Input.GetAxis ("Vertical") == -1)
			{
				mouvements.Move('b',posX,posY);
				canMove=false;
				turn.tour_Hero();
			}
		}

	}





}
