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
	public string tipes="squirrel";
	public struct armeJoueur{
		public string nom;
		public int degat;
		public int distance;
		public string effet;
	}
	private int check;
	armeJoueur arme=new armeJoueur();
	Case[,] tableauCourant;
	// Use this for initialization
	void Start () {
		setEnemy(tipes);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public bool tirer(EnemyScript hero/*vie de la cible*/, HeroScript cible)
	{
		tableauCourant = hero.mouvements.Script.tableauCases;
		int compare;
		switch(arme.effet)
		{
		case "Degat":{
			if(hero.mouvements.posY==cible.mouvements.posY){
				if(hero.mouvements.posX>cible.mouvements.posX) {
					int dep =hero.mouvements.posX;
					compare =dep -cible.mouvements.posX;
				}else{
					int dep =cible.mouvements.posX;
					compare =dep -hero.mouvements.posX;
				}
				//compare=2;
				if(compare==1){
					
				}else{
					if (compare <= arme.distance)
					{
						int check;
						if(hero.mouvements.posY==1)
						{
							check=1;
						}else{
							if(hero.mouvements.posY==2)
							{
								check=2;
							}else{
								if(hero.mouvements.posY==0)
								{
									check=2;
								}
							}
						}
						for (int cpt = 1; cpt <= compare; cpt++)
						{
							if(hero.mouvements.posX>cible.mouvements.posX) {
								if (tableauCourant[hero.mouvements.posX - cpt, hero.mouvements.posY].GetCase() == EtatCase.Empty||tableauCourant[hero.mouvements.posX + cpt, hero.mouvements.posY].GetCase() == EtatCase.HalfObstacle||tableauCourant[hero.mouvements.posX + cpt, hero.mouvements.posY].GetCase() == EtatCase.Trap)
								{
									verif=true;
								}
								else
								{
									verif=false;
									break;
								}
							}else{
								if (tableauCourant[hero.mouvements.posX + cpt, hero.mouvements.posY].GetCase() == EtatCase.Empty||tableauCourant[hero.mouvements.posX + cpt, hero.mouvements.posY].GetCase() == EtatCase.HalfObstacle||tableauCourant[hero.mouvements.posX + cpt, hero.mouvements.posY].GetCase() == EtatCase.Trap)
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
					}
					
					else{
						
						
						verif= false;
					}
				}
			}else{
				if(hero.mouvements.posX==cible.mouvements.posX){
					if(hero.mouvements.posY>cible.mouvements.posY) {
						int dep =hero.mouvements.posY;
						compare =dep -cible.mouvements.posY;
					}else{
						int dep =cible.mouvements.posY;
						compare =dep -hero.mouvements.posY;
					}
					if (compare <= arme.distance)
					{

						if(hero.mouvements.posY==1)
						{
							check=1;
						}else{
							if(hero.mouvements.posY==2)
							{
								check=2;
							}else{
								if(hero.mouvements.posY==0)
								{
									check=2;
								}
							}
						}
						for (int cpt = 1; cpt <= check; cpt++)
						{
							if(hero.mouvements.posY>cible.mouvements.posY) {
								if(arme.distance!=1){
									if (tableauCourant[hero.mouvements.posX , hero.mouvements.posY - cpt].GetCase() == EtatCase.Empty||tableauCourant[hero.mouvements.posX , hero.mouvements.posY - cpt].GetCase() == EtatCase.HalfObstacle||tableauCourant[hero.mouvements.posX , hero.mouvements.posY - cpt].GetCase() == EtatCase.Trap)
									{
										verif=true;
									}
									else
									{
										verif=false;
										break;
									}
								}
							}else{
								if(arme.distance!=1){
									if (tableauCourant[hero.mouvements.posX , hero.mouvements.posY + cpt].GetCase() == EtatCase.Empty||tableauCourant[hero.mouvements.posX , hero.mouvements.posY + cpt].GetCase() == EtatCase.HalfObstacle||tableauCourant[hero.mouvements.posX , hero.mouvements.posY + cpt].GetCase() == EtatCase.Trap)
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

						}
					}
					
					else{
						
						
						verif= false;
					}
				}
				else{
					
					
					verif= false;
				}
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
		health=cible.GetComponent<HealthScript>();
		health.Damage (arme.degat);  
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
					arme.distance=2;
					arme.effet="Degat";
					break;
				}
			case "snake":{
				arme.nom="snake";
				arme.degat=1;
				arme.distance=3;
				arme.effet="Degat";
				break;
			}
			case "bear":{
				arme.nom="bear";
				arme.degat=3;
				arme.distance=2;
				arme.effet="Degat";
				break;
			}
				
			default:{
					arme.nom="squirrel";
					arme.degat=1;
					arme.distance=2;
					arme.effet="Degat";
					break;
				}
		}   
	}
	
}
