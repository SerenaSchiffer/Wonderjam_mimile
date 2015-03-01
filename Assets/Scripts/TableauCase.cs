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
