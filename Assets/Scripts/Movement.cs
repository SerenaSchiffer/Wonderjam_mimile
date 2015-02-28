using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	private const float cellWidth = 1.488f;
	private const float cellHeight = 0.695f;
	private const float cellHeightDecal = 0.65f;
	public int posX = 0;
	public int posY = 0;
	public TableauCase Script;

	///<summary>
	/// Tente de vérifier si la case visée est navigable
	/// </summary>
	public bool verifMove(Case cible)
	{
		if(cible.GetCase() == EtatCase.Empty) 
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	/// <summary>
	/// Termine le mouvement entamé
	/// </summary>
	public bool Move(char direction, int posXOrigine, int posYOrigine) // Directions possible : h, b, g, d
	{
		bool resultat = false;
		Case[,] tableauCourant = Script.tableauCases;
		Case origine = tableauCourant[posXOrigine, posYOrigine];
		Case cible;
		switch (direction) {
			case('h'):
				{
					if(posY <2)
					{
					cible = tableauCourant[posXOrigine, posYOrigine + 1];
					if(verifMove(cible))
					{
						posY++;
						origine.SetEtat(EtatCase.Empty);
						cible.SetEtat(EtatCase.Hero);
						transform.Translate(new Vector3(cellHeightDecal,cellHeight));
						resultat=true;
					}
					}
					break;
				}
			case('b'):
				{
					if(posY >0)
					{
					cible = tableauCourant[posXOrigine, posYOrigine - 1];
					if(verifMove(cible))
					{	
						posY--;
						origine.SetEtat(EtatCase.Empty);
						cible.SetEtat(EtatCase.Hero);
						transform.Translate(new Vector3(-cellHeightDecal,-cellHeight));
						resultat=true;
					}
					}
					break;
				}
			case('d'):
				{
					if(posX<49)
					{
					cible = tableauCourant[posXOrigine+1, posYOrigine];
					if(verifMove(cible))
						{	
							posX++;
							origine.SetEtat(EtatCase.Empty);
							cible.SetEtat(EtatCase.Hero);
							transform.Translate(new Vector3(cellWidth,0));
							resultat=true;
						}
					}
					break;
				}
			case('g'):
				{
					if(posX>0)
					{
					cible = tableauCourant[posXOrigine-1, posYOrigine];
					if(verifMove(cible))
						{
							posX--;
							origine.SetEtat(EtatCase.Empty);
							cible.SetEtat(EtatCase.Hero);
							transform.Translate(new Vector3(-cellWidth,0));
							resultat=true;
						}
					}
					break;
				}
			}
		return resultat;
	}
}