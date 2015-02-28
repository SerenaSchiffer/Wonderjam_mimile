using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

    public Movement mouvements;
	public int range;
	public int damage;
    public HeroScript hero;

    private GameObject enemy;
	private bool spawned;

	// Use this for initialization
	void Start () {
        spawned = false;
        DansLaChampDeLaCamera();
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
                        mouvements.Move('g', mouvements.posX, mouvements.posY);
                    }
                }
                else
                {
                    if (!isThereObstacle('d') && mouvements.posX > 0)
                    {
                        mouvements.Move('d', mouvements.posX, mouvements.posY);
                    }
                }
            }
            else
            {
                if (hero.mouvements.posY == mouvements.posY || hero.mouvements.posX == mouvements.posX)
                {
                    tire actionEnnemi = this.GetComponent<tire>();

                    Debug.Log("L'ennemi attaque");
                }
                else
                {
                    if (enemiEnHaut)
                    {
                        
                        if (!isThereObstacle('b') && mouvements.posY < 2)
                            mouvements.Move('b', mouvements.posX, mouvements.posY);
                    }
                    else
                    {
                        if (!isThereObstacle('h') && mouvements.posY > 0)
                            mouvements.Move('h', mouvements.posX, mouvements.posY);
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

        isObstacle = (mouvements.Script.tableauCases[x, y + 1].GetCase() == EtatCase.Obstacle || mouvements.Script.tableauCases[x, y + 1].GetCase() == EtatCase.HalfObstacle);
        return isObstacle;
    }
}
