using UnityEngine;
using System.Collections;

public class HeroScript : MonoBehaviour {
	public bool canMove;
	public Movement mouvements;
	public turn_Manager turn;



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
			bool resultat;
			if(Input.GetAxis ("Horizontal") == 1)
			{
				resultat = mouvements.Move('d',posX,posY);
				if(resultat)
				{
					canMove=false;
				}
			}
			if(Input.GetAxis ("Horizontal") == -1)
			{
				resultat = mouvements.Move('g',posX,posY);
				if(resultat)
				{
				canMove=false;
				}
			}
			if(Input.GetAxis ("Vertical") == 1)
			{
				resultat = mouvements.Move('h',posX,posY);
				if(resultat)
				{
				canMove=false;
				}
			}
			if(Input.GetAxis ("Vertical") == -1)
			{
				resultat = mouvements.Move('b',posX,posY);
				if(resultat)
				{
				canMove=false;
				}
			}
		}

	}





}
