using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum WeaponType
{
	Rock,
	Marble,
	Jack,
	Bone,
	Cat,
	Wand1,
	Wand2,
	Wand3
};

public class GetItem : MonoBehaviour {
	public WeaponType weaponType;
	public int posX;
	public int posY;
	private HeroScript hero;
	private bool itemTaken;
	public TableauCase Script;

	public Transform button;
	public Texture2D atexture;


	public void GiveWeaponToPlayer(WeaponType weaponType)
	{
		if (!itemTaken) {
			switch (weaponType) {
			case(WeaponType.Rock):
				{
					//Permettre l'utilisation dans l'interface
					Debug.Log ("Tu as pris une roche !");
					Destroy (gameObject);
					Script.tableauCases[posX,posY].SetEtat(EtatCase.Empty);
					button.GetComponent<CanvasGroup>().interactable = true;
					OnGUI();
					
					break;
				}
			case(WeaponType.Bone):
				{
					//Permettre l'utilisation dans l'interface
					break;
				}
			case(WeaponType.Jack):
				{
					//Permettre l'utilisation dans l'interface
					break;
				}
			case(WeaponType.Marble):
				{
					//Permettre l'utilisation dans l'interface
					break;
				}
			case(WeaponType.Cat):
				{
					//Permettre l'utilisation dans l'interface
					break;
				}
			}
		}

	}




	// Use this for initialization
	void Start () {
		hero = GameObject.FindObjectOfType<HeroScript>();
	}

	void OnMouseUp(){
		//Vérification de la distance
		int posHeroX = hero.mouvements.posX;
		int posHeroY = hero.mouvements.posY;
		if (posX == posHeroX && posY == posHeroY + 1) 
		{
			GiveWeaponToPlayer (weaponType);
			itemTaken=true;
		}
		if (posX == posHeroX && posY == posHeroY - 1)
		{
			GiveWeaponToPlayer (weaponType);
			itemTaken=true;
		}
		if (posY == posHeroY && posX == posHeroX + 1)
		{
			GiveWeaponToPlayer (weaponType);
			itemTaken=true;
		}
		if (posY == posHeroY && posX == posHeroX - 1)
		{
			GiveWeaponToPlayer (weaponType);
			itemTaken=true;
		};
	}


	// Update is called once per frame
	void Update () {
	}


	void OnGUI() {
		if (!atexture) {
			Debug.LogError("Assign a Texture in the inspector.");
			return;
		}
		GUI.DrawTexture(new Rect(10, 10, 60, 60), atexture, ScaleMode.ScaleToFit, true, 10.0F);
	}

}
