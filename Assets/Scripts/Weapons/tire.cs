using UnityEngine;
using System.Collections;

public class tire : MonoBehaviour {

    private bool verif=true;
    
	public HealthScript health;
          
    public struct armeJoueur{
        public string nom;
        public int degat;
        public int distance;
        public string effet;
    }

	public int showdamage;

    armeJoueur arme=new armeJoueur();
    Case[,] tableauCourant;
	// Use this for initialization
	void Start () {
		arme.nom="roche";
		arme.degat=1;
		arme.distance=3;
		arme.effet="Degat";
		
	}
	
	// Update is called once per frame
	void Update () {
	}
    public bool tirer(HeroScript hero, EnemyScript cible)
    {
		verif = true;
		int compare;
		tableauCourant = hero.mouvements.Script.tableauCases;
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
						 for (int cpt = 1; cpt <= compare; cpt++)
			                 {
								
							if (tableauCourant[hero.mouvements.posX + cpt, hero.mouvements.posY].GetCase() == EtatCase.Enemy||tableauCourant[hero.mouvements.posX + cpt, hero.mouvements.posY].GetCase() == EtatCase.Empty||tableauCourant[hero.mouvements.posX + cpt, hero.mouvements.posY].GetCase() == EtatCase.HalfObstacle||tableauCourant[hero.mouvements.posX + cpt, hero.mouvements.posY].GetCase() == EtatCase.Trap)
				                     {
				                        verif=true;
				                     }
				                     else
				                     {
										if (tableauCourant[hero.mouvements.posX + compare, hero.mouvements.posY].GetCase() == EtatCase.Enemy)
										{
											verif=true;
										}else{
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
						
						for (int cpt = 1; cpt <= compare; cpt++)
						{
							if(arme.distance!=1){
								if (tableauCourant[hero.mouvements.posX , hero.mouvements.posY + cpt].GetCase() == EtatCase.Enemy||tableauCourant[hero.mouvements.posX , hero.mouvements.posY + cpt].GetCase() == EtatCase.Empty||tableauCourant[hero.mouvements.posX , hero.mouvements.posY + cpt].GetCase() == EtatCase.HalfObstacle||tableauCourant[hero.mouvements.posX , hero.mouvements.posY + cpt].GetCase() == EtatCase.Trap)
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
				else{
					
					
					verif= false;
				}
			}
			break;
			}
			case "Repousser":{
				for(int cpt=0;cpt<arme.distance;cpt++)
				{
					if (tableauCourant[hero.mouvements.posX + cpt, hero.mouvements.posY].GetCase() == EtatCase.Empty)
					{
                        verif=true;
                     }
                     else
                     {
                         verif=false;
                         break;
                     }
                 }
                     if(verif==true)
                     {
                         for(int cpt=1;cpt<=2/*nb de case ou on le repousse*/;cpt++)
                         {


							if (tableauCourant[hero.mouvements.posX + cpt, hero.mouvements.posY].GetCase() ==  EtatCase.Empty)
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
	private void attack(EnemyScript cible)
    {
		gameObject.GetComponent<Animator>().SetTrigger("shoot");
        switch(arme.effet)
        {
            case "Degat":{

				Debug.Log (arme.degat);
				health=cible.GetComponent<HealthScript>();
			Debug.Log(arme.degat);
				health.Damage (arme.degat);

               
                break;
            }
            case "Repousser":{
                /*faire reculer de 2 l'enemi*/                
                break;
            }
            case "Immobilise":{
                /*vas falloir faire un verif sur les enemy/hero avec une variable int pour le nombre de tour ou il sont imobiliser (if(immobiliser==0 fait de quoi else tour=fini))*/
                break;
            }
            
            default:{
                
                break;
            }
        }   
    }
    public void changerArme(string nom)
    {


        switch(nom)
        {
            case "roche":{
			Debug.Log("Roche");
                arme.nom="roche";
                arme.degat=1;
                arme.distance=3;
                arme.effet="Degat";
                break;
            }
            case "bille":{
			Debug.Log ("SVP");
                arme.nom="bille";
                arme.degat=2;
                arme.distance=3;
                arme.effet="Degat";
                break;
            }
            case "boite":{
                arme.nom="boite";
                arme.degat=0;
                arme.distance=2;
			arme.effet="Degat";
                break;
            }
            case"femure":{
                arme.nom="femure";
                arme.degat=3;
                arme.distance=1;
                arme.effet="Degat";
			Debug.Log(arme.degat);
                break;
            }
            case"chat":{
                arme.nom="chat";
                arme.degat=0;
                arme.distance=3;
			arme.effet="Degat";
                break;
            }
            case"baguette":{//indeterminer
                arme.nom="baguette";
                arme.degat=1;
                arme.distance=2;
                arme.effet="Degat";
                break;
            }
            default:{
			Debug.Log("je bug");
                arme.nom="roche";
                arme.degat=1;
                arme.distance=2;
                arme.effet="Degat";
                break;
            }
        }   
    }

    
}
