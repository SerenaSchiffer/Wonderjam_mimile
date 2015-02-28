using UnityEngine;
using System.Collections;

public class tireEnemy : MonoBehaviour {
	/*
		====================IMPORTANT=========================
		le mot hero définie le personnage qui tire meme si ici
		c'est un enemy.
		======================================================
	 */
	
	private bool verif=true;
	
	public HealthScript health;
	
	public struct armeJoueur{
		public string nom;
		public int degat;
		public int distance;
		public string effet;
	}
	armeJoueur arme=new armeJoueur();
	Case[,] tableauCourant;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public bool tirer(EnemyScript hero/*vie de la cible*/, HeroScript cible)
	{
		tableauCourant = hero.mouvements.Script.tableauCases;
		switch(arme.effet)
		{
		case "Degat":{
			int dep =hero.mouvements.posX;
			int compare =dep -cible.mouvements.posX;
			if (compare <= arme.distance)
			{
				if(hero.mouvements.posY==cible.mouvements.posY)
				{
					for (int cpt = 0; cpt < arme.distance; cpt++)
					{
						if (tableauCourant[hero.mouvements.posX - cpt, hero.mouvements.posY].GetCase() == EtatCase.Empty)
						{
							verif=true;
						}
						else
						{
							verif=false;
							break;
						}
					}
				}
				else{
					verif=false;
				}
			}
			else{
				
				
				verif= false;
			}
			
			break;
		}
		
		default:{
			
			break;
		}
		}
		if(verif==true)
		{
			attack(cible);
		}
		else
		{
			verif= false;
		}
		return verif;
		
	}
	private void  attack(HeroScript cible)
	{
		
		switch(arme.effet)
		{
			case "Degat":{
				health=cible.GetComponent<HealthScript>();
				health.hp -= arme.degat;
				
				
				break;
			}
			
				
			default:{
				
				break;
			}
		}   
	}

	public void setEnemy(string nom)
	{
		/*
		====================IMPORTANT=========================
		c'est ici que seront ajouter les différent type 
		d'enemi avec leur degat
		======================================================		
		 */
		switch(nom)
		{
		case "squirrel":{
				arme.nom="squirrel";
				arme.degat=1;
				arme.distance=1;
				arme.effet="Degat";
				break;
			}

			default:{
				arme.nom="squirrel";
				arme.degat=1;
				arme.distance=1;
				arme.effet="Degat";
				break;
			}
		}   
	}
	
}
