using UnityEngine;
using System.Collections;

public class HeroScript : MonoBehaviour {
    private string nomStage;
    private int nbCaseLevel;
	public bool canMove;
	public Movement mouvements;
	public turn_Manager turn;
	public tire shooter;
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
			bool resultat;
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

            switch (nomStage)
            {
                case "stage1":
                    nbCaseLevel = 26;
                    break;

                case "stage2":
                    nbCaseLevel = 29;
                    break;

                case "stage3":
                    //TODO: faire un processus de victoire.
                    break;
            }
		}
	}

    void OnDestroy()
    {
        const int buttonWidth = 120;
		const int buttonHeight = 60;

        if (GUI.Button (new Rect (Screen.width / 2 - (buttonWidth / 2), (1 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight ), "Retry !"))
        {
            Debug.Log(Application.loadedLevelName);
        }
    }
}
