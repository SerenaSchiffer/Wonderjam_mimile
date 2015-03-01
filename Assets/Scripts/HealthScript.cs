using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

	public int hp = 1;
	public Slider healthBarSlider;
	private bool isDead;

	public void Damage(int damage)
	{
		hp -= damage;
		if (healthBarSlider != null) {
			healthBarSlider.value -=damage;  //reduce health
		}

		if (hp <= 0) 
		{
			gameObject.GetComponent<Animator>().SetTrigger("Die");
		}
	}

}
