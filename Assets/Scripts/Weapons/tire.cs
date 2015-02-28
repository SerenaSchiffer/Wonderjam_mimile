using UnityEngine;
using System.Collections;

public class tire : MonoBehaviour {
    private int degat;
    private bool verif=true;
	// Use this for initialization
	void Start () {
	 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public bool tirer(/*objet de depart*/,/*objet sur le quelle on tire*/,int distanceTire){
        if(/*coordoEmplacement tireX*/-/*coordoDeparX*/1<=distanceTire)
        {
             for(int cpt=0;cpt<distanceTire;cpt++)
             {
                 if(/*case [coordoDepartX+cpt,coordoDeparty]*/==/*rien ou demi mur*/)
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
                degat(/*objet sur le quelle on tire*/);
             }
             else
             {
                verif= false;
             }
        }else
        {
            verif= false;
        }
        return verif;

    }
    private void degat(/*objet sur le quelle on tire*/){
        /*objet ataquer*/.healt-=degat;

        if(/*objet de la classe*/.healt==0){
            Destroy(/*L'objet de la case*/);
        }
    }
}
