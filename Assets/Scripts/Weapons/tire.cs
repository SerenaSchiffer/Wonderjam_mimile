using UnityEngine;
using System.Collections;

public class tire : MonoBehaviour {
    private int degat;
    private bool verif=true;
    public TableauCase script;
    Case[,] tableauCourant = GameObject.Find("/nomPrefabTableau");
          
    public struct armeJoueur{
        string nom;
        int degat;
        int distance;
        string effet;
    }
    armeJoueur arme=new armeJoueur();
	// Use this for initialization
	void Start () {
	 
	}
	1
	// Update is called once per frame
	void Update () {
	
	}
    public bool tirer(string Depart/*vie de la cible*/,string Fin){
        switch(arme.effet)
        {
            case "Degat":{
                if (GameObject.Find("/" + Depart + "/Movement").posX - GameObject.Find("/" + Fin + "/Movement").posX <= arme.distance)
               {

                 for(int cpt=0;cpt<distanceTire;cpt++)
                 {
                     if (tableauCourant[GameObject.Find("/" + Depart + "/Movement").posX + cpt, GameObject.Find("/" + Depart + "/Movement").posY] == EtatCase.Empty)
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
        
        
                    verif= false;
                }
        
                break;
            }
            case "Repousser":{
                 for(int cpt=0;cpt<distanceTire;cpt++)
                 {
                     if (tableauCourant[GameObject.Find("/" + Depart + "/Movement").posX + cpt, GameObject.Find("/" + Depart + "/Movement").posY] == EtatCase.Empty)
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
                             if (tableauCourant[GameObject.Find("/" + Depart + "/Movement").posX + cpt, GameObject.Find("/" + Depart + "/Movement").posY] == EtatCase.Empty)
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
             attack(Fin);
        }
        else
        {
             verif= false;
        }
        return verif;

    }
    private void attack(string nom){
        
        switch(arme.effet)
        {
            case "Degat":{
                GameObject.Find("/" + Depart + "/HealthScript").Hp -= degat;

               
                break;
            }
            case "Repousser":{
                GameObject.Find("/" + Depart + "/Movement").PosX + 2;                
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
                arme.distance=2;
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
