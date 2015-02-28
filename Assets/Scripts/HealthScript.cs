using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public int hp = 1;

	public void Damage(int damage)
	{
		hp -= damage;

		if (hp <= 0) 
		{
			Destroy(gameObject);
		}
	}
}
