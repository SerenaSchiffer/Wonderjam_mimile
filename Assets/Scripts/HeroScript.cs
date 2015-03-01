using UnityEngine;
using System.Collections;

public class HeroScript : MonoBehaviour {
    private string nomStage;
    private int nbCaseLevel;
	public bool canMove;
	public Movement mouvements;
	public turn_Manager turn;
	public tire shooter;
	public bool bille;

	public void test_bille(bool test)
	{
		  bille = test;

	}

	public void setArme(string arme){
		EnemyScript[] enemies = GameObject.FindObjectsOfType<EnemyScript>();

		foreach(EnemyScript enemy in enemies)
		{		

				enemy.setWeapon(arme);

		}
	}
	// Use this for initialization
	void Start () {
        canMove = true;
        nomStage = Application.loadedLevelName;
	}

	void Update(){
	}

	public void KillSelf(){
		Destroy (gameObject);

	}


	// Update is called once per frame
	void FixedUpdate ()
    {
        
		if (canMove) 
		{            
			int posX = mouvements.posX;
			int posY = mouvements.posY;
            bool resultat = false;
			if(Input.GetAxis ("Horizontal") == 1)
			{
				resultat = mouvements.Move('d',posX,posY);
				if(resultat)
				{
					canMove = false;
				}
			}
			if(Input.GetAxis ("Horizontal") == -1)
			{
				resultat = mouvements.Move('g',posX,posY);
				if(resultat)
				{
                    canMove = false;
				}
			}
			if(Input.GetAxis ("Vertical") == 1)
			{
				resultat = mouvements.Move('h',posX,posY);
				if(resultat)
				{
                    canMove = false;
				}
			}
			if(Input.GetAxis ("Vertical") == -1)
			{
				resultat = mouvements.Move('b',posX,posY);
				if(resultat)
				{
                    canMove = false;
				}
			}

            if (resultat)
            {
                switch (nomStage)
                {
                    case "stage1":
                        {
                            if (mouvements.posX == 26)
                                Application.LoadLevel("stage2");
                        }
                        break;

                    case "stage2":
                        {
                            if (mouvements.posX == 29)
                                Application.LoadLevel("stage3");
                        }
                        break;

                    case "stage3":
                        //TODO: faire un processus de victoire.
                        break;
                }
            }
		}        
	}
}
