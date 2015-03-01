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
	bille,
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
	public bool isset;
	public Transform button;
	public Texture2D atexture;
	public bool popup = true;


	public void GiveWeaponToPlayer(WeaponType weaponType)
	{
		if (!itemTaken) {
			switch (weaponType) {
			case(WeaponType.Rock):
				{
					//Permettre l'utilisation dans l'interface
					Debug.Log ("Tu as pris une roche !");
					Script.tableauCases[posX,posY].SetEtat(EtatCase.Empty);
					button.GetComponent<CanvasGroup>().interactable = true;
					isset = true;
					Invoke("desactiverPopUp", 5);
					Destroy(gameObject.renderer);

					break;
				}
			case(WeaponType.Bone):
				{
					//Permettre l'utilisation dans l'interface
					Debug.Log ("Tu as pris un fémur !");
					button.GetComponent<CanvasGroup>().interactable = true;
					isset = true;
					Invoke ("desactiverPopUp", 5);
					Destroy (gameObject.renderer);
					break;
				}
			case(WeaponType.Jack):
				{
					//Permettre l'utilisation dans l'interface
					button.GetComponent<CanvasGroup>().interactable = true;
					isset=true;
					Invoke("desactiverPopUp", 5);
					Destroy (gameObject.renderer);
					Script.tableauCases[posX,posY].SetEtat(EtatCase.Empty);
					break;
				}
			case(WeaponType.Marble):
				{
					//Permettre l'utilisation dans l'interface
					button.GetComponent<CanvasGroup>().interactable = true;
					isset=true;
					Invoke("desactiverPopUp", 5);
					Destroy (gameObject.renderer);
					break;
				}
			case(WeaponType.Cat):
				{
				Debug.Log ("Tu as pris une bille !");
				button.GetComponent<CanvasGroup>().interactable = true;
				isset = true;
				Invoke ("desactiverPopUp", 5);
				Destroy (gameObject.renderer);
				break;
				}

			case(WeaponType.bille):
			{
				
				Debug.Log ("Tu as pris une bille !");
				button.GetComponent<CanvasGroup>().interactable = true;
				isset = true;
				Invoke ("desactiverPopUp", 5);
				Destroy (gameObject.renderer);
				break;
			}
			}
		}

	}

	void desactiverPopUp()
	{
		popup = false;
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


	void OnGUI() 
	
	{	
		if (isset && popup) {
			GUI.DrawTexture (new Rect ((Screen.width/2)-(450), (Screen.height/2)-(300), 900, 600), atexture, ScaleMode.StretchToFill, true, 10.0F);
		}
	}

}
