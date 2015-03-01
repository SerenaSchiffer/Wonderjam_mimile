using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

    public Movement mouvements;
	public int range;
	public int damage;
    public HeroScript hero;

    private GameObject enemy;
	private bool spawned;
    private bool resultat;

	// Use this for initialization
	void Start () {
        spawned = false;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void Move()
	{
        if (spawned)
        {
            bool enemiADroite = mouvements.posX > hero.mouvements.posX;
            bool enemiEnHaut = mouvements.posY > hero.mouvements.posY;
            int distance = getDistance(enemiADroite);
            if (distance > 1)
            {
                if (enemiADroite)
                {
                    if (!isThereObstacle('g') && mouvements.posX < 49)
                    {
                        resultat = mouvements.Move('g', mouvements.posX, mouvements.posY);
                        mouvements.Script.tableauCases[mouvements.posX, mouvements.posY].SetEtat(EtatCase.Enemy);
                    }
                    else
                    {
                        eviterObstacle();
                    }
                }
                else
                {
                    if (!isThereObstacle('d') && mouvements.posX > 0)
                    {
                        resultat = mouvements.Move('d', mouvements.posX, mouvements.posY);
                        mouvements.Script.tableauCases[mouvements.posX , mouvements.posY].SetEtat(EtatCase.Enemy);
                    }
                    else
                    {
                        eviterObstacle();
                    }
                }
            }
            else
            {
                if (hero.mouvements.posY == mouvements.posY || hero.mouvements.posX == mouvements.posX)
                {
                    tireEnemy actionEnnemi = this.GetComponent<tireEnemy>();
                    Debug.Log("Ennemi attaque");
                    actionEnnemi.tirer(this, hero);
                }
                else
                {
                    if (enemiEnHaut)
                    {
                        if (!isThereObstacle('b') && mouvements.posY > 0)
                        {
                            Debug.Log("NOOOON");
                            resultat = mouvements.Move('b', mouvements.posX, mouvements.posY);
                            mouvements.Script.tableauCases[mouvements.posX, mouvements.posY].SetEtat(EtatCase.Enemy);
                        }
                        else
                        {
                            Debug.Log("OUIIII");
                            if (enemiADroite)
                            {
                                if (!isThereObstacle('g') && mouvements.posY < 49)
                                {
                                    resultat = mouvements.Move('g', mouvements.posX, mouvements.posY);
                                    mouvements.Script.tableauCases[mouvements.posX, mouvements.posY].SetEtat(EtatCase.Enemy);
                                }
                            }
                            else
                            {
                                if (!isThereObstacle('d') && mouvements.posY > 0)
                                {
                                    resultat = mouvements.Move('d', mouvements.posX, mouvements.posY);
                                    mouvements.Script.tableauCases[mouvements.posX, mouvements.posY].SetEtat(EtatCase.Enemy);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (!isThereObstacle('h') && mouvements.posY < 2)
                        {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
                            resultat = mouvements.Move('h', mouvements.posX, mouvements.posY);
                            mouvements.Script.tableauCases[mouvements.posX, mouvements.posY].SetEtat(EtatCase.Enemy);
                        }
                        else
                        {
                            Debug.Log("OUIIII");
                            if (enemiADroite)
                            {
                                if (!isThereObstacle('g') && mouvements.posY < 49)
                                {
                                    resultat = mouvements.Move('g', mouvements.posX, mouvements.posY);
                                    mouvements.Script.tableauCases[mouvements.posX, mouvements.posY].SetEtat(EtatCase.Enemy);
                                }
                            }
                            else
                            {
                                if (!isThereObstacle('d') && mouvements.posY > 0)
                                {
                                    resultat = mouvements.Move('d', mouvements.posX, mouvements.posY);
                                    mouvements.Script.tableauCases[mouvements.posX, mouvements.posY].SetEtat(EtatCase.Enemy);
                                }
                            }
                        }
                    }
                }
            }
        }
	}

    public void DansLaChampDeLaCamera()
    {
        if (renderer.IsVisibleFrom(Camera.main))
        {
            spawned = true;
        }
    }

    private int getDistance(bool enemiEnAvant)
    {
        int distance;

        if (enemiEnAvant)
        {
            distance = mouvements.posX - hero.mouvements.posX;
        }
        else
        {
            distance = hero.mouvements.posX - mouvements.posX;
        }
        
        return distance;
    }

    private bool isThereObstacle(char direction)
    {
        bool isObstacle;
        int x = mouvements.posX;
        int y = mouvements.posY;

        switch(direction)
        {
            case 'h':
                    isObstacle = isCaseObstable(x, y + 1);
                break;

            case 'b':
                    isObstacle = isCaseObstable(x, y - 1);
                break;

            case 'd':
                isObstacle = isCaseObstable(x + 1, y);
                break;

            case 'g':
                isObstacle = isCaseObstable(x - 1, y);
                break;

            default:
                isObstacle = false;
                break;
        }

        return isObstacle;
    }

    private bool isCaseObstable(int x, int y)
    {
        bool isObstacle;

        isObstacle = (mouvements.Script.tableauCases[x, y].GetCase() == EtatCase.Obstacle || mouvements.Script.tableauCases[x, y].GetCase() == EtatCase.HalfObstacle
                      || mouvements.Script.tableauCases[x, y].GetCase() == EtatCase.Enemy);
        return isObstacle;
    }

	public void OnMouseUp()
	{
		hero.shooter.changerArme ("roche");
        if (hero.shooter.tirer(hero, this))
            hero.turn.tour(false);

	}

    private void eviterObstacle()
    {
        if (mouvements.posY == 2)
        {
            if (!isThereObstacle('b') && mouvements.posY > 0)
            {
                resultat = mouvements.Move('b', mouvements.posX, mouvements.posY);
            }
        }
        else if (mouvements.posY == 0)
        {
            if (!isThereObstacle('h') && mouvements.posY < 2)
            {
                resultat = mouvements.Move('h', mouvements.posX, mouvements.posY);
            }
        }
        else
        {
            if (!isThereObstacle('h') && mouvements.posY < 2)
            {
                resultat = mouvements.Move('h', mouvements.posX, mouvements.posY);
            }
            else if (!isThereObstacle('b') && mouvements.posY > 0)
            {
                resultat = mouvements.Move('b', mouvements.posX, mouvements.posY);
            }
        }
    }

	void OnDestroy()
	{
		mouvements.Script.tableauCases [mouvements.posX, mouvements.posY].SetEtat (EtatCase.Empty);
	}

	void DestroyThisObject()
	{
		Destroy (gameObject);
	}

}
