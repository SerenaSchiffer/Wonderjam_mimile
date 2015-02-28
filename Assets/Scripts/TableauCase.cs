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
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void ChangerEtatCase(EtatCase nouvEtat, int x, int y)
    {
        tableauCases[x, y].SetEtat(nouvEtat);
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

    public void SetEtat(EtatCase etat)
    {
        this.etat = etat;
    }

    public EtatCase GetCase()
    {
        return etat;
    }
}
