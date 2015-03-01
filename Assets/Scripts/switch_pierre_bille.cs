using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class switch_pierre_bille : MonoBehaviour {

	public Sprite newsprite;
	public bool condition;
	public Button button;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void changer_iamge(bool condition)
	{
		if(condition)
		button.image.sprite = newsprite;
		Debug.Log("Rentre");
	}


}
