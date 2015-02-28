using UnityEngine;
using System.Collections;

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


	public void GiveWeaponToPlayer(WeaponType weaponType)
	{
		switch (weaponType) 
		{
		case(WeaponType.Rock) :
			{
				//Permettre l'utilisation dans l'interface
				break;
			}
		case(WeaponType.Bone) :
			{
				//Permettre l'utilisation dans l'interface
				break;
			}
		case(WeaponType.Jack) :
			{
				//Permettre l'utilisation dans l'interface
				break;
			}
		case(WeaponType.Marble) :
			{
				//Permettre l'utilisation dans l'interface
				break;
			}
		case(WeaponType.Cat) :
			{
				//Permettre l'utilisation dans l'interface
				break;
			}
		}

	}




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
