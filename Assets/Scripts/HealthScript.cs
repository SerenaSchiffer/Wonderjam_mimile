using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

	public int hp = 1;
	public Slider healthBarSlider;


	public void Damage(int damage)
	{
		hp -= damage;

		healthBarSlider.value -= 1;  //reduce health

		if (hp <= 0) 
		{
			Destroy(gameObject);
		}
	}


}
