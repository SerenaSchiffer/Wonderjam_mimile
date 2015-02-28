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
    armeJoueur arme=new armeJoueur();
    Case[,] tableauCourant;
	// Use this for initialization
	void Start () {
		arme.nom="roche";
		arme.degat=1;
		arme.distance=1;
		arme.effet="Degat";

	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public bool tirer(HeroScript hero, EnemyScript cible)
    {
		int compare;
		tableauCourant = hero.mouvements.Script.tableauCases;
        switch(arme.effet)
        {
            case "Degat":{
			if(hero.mouvements.posX>cible.mouvements.posX) {
				int dep =hero.mouvements.posX;
				compare =dep -cible.mouvements.posX+1;
			}else{
				int dep =cible.mouvements.posX;
				compare =dep -hero.mouvements.posX-1;
			}
                if (compare <= arme.distance)
               {
				if(hero.mouvements.posY==cible.mouvements.posY){
	                   for (int cpt = 1; cpt <= arme.distance; cpt++)
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
                     else
                     {
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
	private void attack(EnemyScript cible)
    {
        
        switch(arme.effet)
        {
            case "Degat":{
				health=cible.GetComponent<HealthScript>();
				health.Damage (arme.degat);

               
                break;
            }
            case "Repousser":{
                cible.mouvements.posX += 2;                
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
                arme.nom="roche";
                arme.degat=1;
                arme.distance=1;
                arme.effet="Degat";
                break;
            }
            case "bille":{
                arme.nom="bille";
                arme.degat=1;
                arme.distance=2;
                arme.effet="Degat";
                break;
            }
            case "boite":{
                arme.nom="boite";
                arme.degat=1;
                arme.distance=2;
                arme.effet="Repousser";
                break;
            }
            case"femure":{
                arme.nom="femure";
                arme.degat=1;
                arme.distance=2;
                arme.effet="Degat";
                break;
            }
            case"chat":{
                arme.nom="chat";
                arme.degat=1;
                arme.distance=2;
                arme.effet="Immobilise";
                break;
            }
            case"baguette":{
                arme.nom="baguette";
                arme.degat=1;
                arme.distance=2;
                arme.effet="Degat";
                break;
            }
            default:{
                arme.nom="roche";
                arme.degat=1;
                arme.distance=2;
                arme.effet="Degat";
                break;
            }
        }   
    }

    
}
