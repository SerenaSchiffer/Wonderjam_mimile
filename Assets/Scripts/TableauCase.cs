using UnityEngine;
using System.Collections;

public enum EtatCase 
{
    Empty,
    Hero,
    Enemy,
    Obstacle,
    HalfObstacle,
    Trap 
};

public class TableauCase : MonoBehaviour {
	public int mapNumber = 0;
    public Case[,] tableauCases;

	// Use this for initialization
	void Start () {
        tableauCases = new Case[50, 3];

        for (int i = 0; i < 50; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tableauCases[i, j] = new Case(EtatCase.Empty);
            }
        }

		GenerateMap (mapNumber);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void ChangerEtatCase(EtatCase nouvEtat, int x, int y)
    {
        tableauCases[x, y].SetEtat(nouvEtat);
    }

	public void GenerateMap(int mapNumber)
	{
		switch (mapNumber) 
		{
			case 0 :
			{
			Debug.Log ("Entrée sur la map de test");
			tableauCases[2,2].SetEtat(EtatCase.Obstacle);
			tableauCases[2,0].SetEtat(EtatCase.HalfObstacle);
			tableauCases[3,0].SetEtat(EtatCase.Trap);
			tableauCases[4,2].SetEtat(EtatCase.Trap);
			break;
			}

			case 1 :
			{
			Debug.Log ("Entrée sur le niveau 1");
			tableauCases[2,0].SetEtat(EtatCase.Obstacle);
			tableauCases[2,1].SetEtat(EtatCase.HalfObstacle);
			tableauCases[2,2].SetEtat(EtatCase.Obstacle);
			tableauCases[3,2].SetEtat(EtatCase.Obstacle);
			tableauCases[5,0].SetEtat(EtatCase.Obstacle);
			tableauCases[5,1].SetEtat(EtatCase.HalfObstacle);
			tableauCases[8,2].SetEtat(EtatCase.Obstacle);
			tableauCases[9,1].SetEtat(EtatCase.Obstacle);
			tableauCases[10,1].SetEtat(EtatCase.HalfObstacle);
			tableauCases[13,1].SetEtat(EtatCase.Obstacle);
			tableauCases[16,0].SetEtat(EtatCase.HalfObstacle);
			tableauCases[16,2].SetEtat(EtatCase.Obstacle);
			tableauCases[19,1].SetEtat(EtatCase.HalfObstacle);
			tableauCases[20,1].SetEtat(EtatCase.HalfObstacle);
			tableauCases[21,1].SetEtat(EtatCase.HalfObstacle);
			tableauCases[26,0].SetEtat(EtatCase.Obstacle);
			tableauCases[26,2].SetEtat(EtatCase.Obstacle);
			tableauCases[27,0].SetEtat(EtatCase.Obstacle);
			tableauCases[27,1].SetEtat(EtatCase.Obstacle);
			tableauCases[27,2].SetEtat(EtatCase.Obstacle);
			break;
			}
		case 2 :
		{
			Debug.Log ("Entrée sur le niveau 2");
			tableauCases[3,0].SetEtat(EtatCase.Obstacle);
			tableauCases[3,2].SetEtat(EtatCase.Obstacle);
			tableauCases[4,0].SetEtat(EtatCase.Obstacle);
			tableauCases[5,0].SetEtat(EtatCase.HalfObstacle);
			tableauCases[5,1].SetEtat(EtatCase.Obstacle);
			tableauCases[7,1].SetEtat(EtatCase.HalfObstacle);
			tableauCases[7,2].SetEtat(EtatCase.HalfObstacle);
			tableauCases[10,0].SetEtat(EtatCase.Obstacle);
			tableauCases[10,2].SetEtat(EtatCase.Obstacle);
			tableauCases[12,0].SetEtat(EtatCase.HalfObstacle);
			tableauCases[12,1].SetEtat (EtatCase.Obstacle);
			tableauCases[14,2].SetEtat(EtatCase.Obstacle);
			tableauCases[15,1].SetEtat(EtatCase.Obstacle);
			tableauCases[15,2].SetEtat(EtatCase.Obstacle);
			tableauCases[16,1].SetEtat(EtatCase.HalfObstacle);
			tableauCases[18,0].SetEtat(EtatCase.Obstacle);
			tableauCases[18,1].SetEtat(EtatCase.Obstacle);
			tableauCases[20,1].SetEtat(EtatCase.HalfObstacle);
			tableauCases[20,2].SetEtat(EtatCase.HalfObstacle);
			tableauCases[22,1].SetEtat(EtatCase.HalfObstacle);
			tableauCases[23,1].SetEtat(EtatCase.Obstacle);
			tableauCases[25,0].SetEtat(EtatCase.Obstacle);
			tableauCases[25,1].SetEtat(EtatCase.HalfObstacle);
			tableauCases[28,0].SetEtat(EtatCase.HalfObstacle);
			tableauCases[28,2].SetEtat(EtatCase.HalfObstacle);
			tableauCases[30,0].SetEtat(EtatCase.Obstacle);
			tableauCases[30,1].SetEtat(EtatCase.Obstacle);
			tableauCases[30,2].SetEtat(EtatCase.Obstacle);
			break;
		}

		case 3 :
		{
			Debug.Log ("Entrée sur le niveau 3");
			tableauCases[3,0].SetEtat(EtatCase.Obstacle);
			tableauCases[3,2].SetEtat(EtatCase.Obstacle);
			tableauCases[4,0].SetEtat(EtatCase.Obstacle);
			tableauCases[5,0].SetEtat(EtatCase.Obstacle);
			tableauCases[5,2].SetEtat(EtatCase.HalfObstacle);
			tableauCases[6,0].SetEtat(EtatCase.Obstacle);
			tableauCases[8,2].SetEtat(EtatCase.Obstacle);
			tableauCases[9,1].SetEtat(EtatCase.Obstacle);
			tableauCases[9,2].SetEtat(EtatCase.Obstacle);
			tableauCases[10,1].SetEtat(EtatCase.HalfObstacle);
			tableauCases[12,0].SetEtat(EtatCase.Obstacle);
			tableauCases[12,2].SetEtat(EtatCase.Obstacle);
			tableauCases[15,1].SetEtat(EtatCase.Obstacle);
			tableauCases[16,1].SetEtat(EtatCase.HalfObstacle);
			tableauCases[17,1].SetEtat(EtatCase.Obstacle);
			tableauCases[18,1].SetEtat(EtatCase.Obstacle);
			tableauCases[19,1].SetEtat(EtatCase.HalfObstacle);
			tableauCases[20,1].SetEtat(EtatCase.Obstacle);
			tableauCases[21,1].SetEtat(EtatCase.Obstacle);
			tableauCases[22,1].SetEtat(EtatCase.Obstacle);
			tableauCases[22,2].SetEtat(EtatCase.Obstacle);
			break;
		}

		}
	}
}





public class Case
{
    private EtatCase etat;
    public object contenuCase;

    public Case()
    {
        etat = EtatCase.Empty;
    }

	public Case(EtatCase etatCase)
	{
		etat = etatCase;
	}

    public Case(EtatCase etat, object gameObject)
    {
        this.etat = etat;
        contenuCase = gameObject;
    }

    public void SetEtat(EtatCase etat)
    {
        this.etat = etat;
    }

    public EtatCase GetCase()
    {
        return etat;
    }
}
