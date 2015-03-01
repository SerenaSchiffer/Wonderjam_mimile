using UnityEngine;
using System.Collections;

public class ending_script : MonoBehaviour {

	public bool isset;
	public bool isset_2;
	public Texture2D atexture,another;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		Invoke ("load", 2);

		if (isset) 
			GUI.DrawTexture (new Rect ((Screen.width / 2) - (300), (Screen.height / 2) - (500), 931, 1024), atexture, ScaleMode.StretchToFill, true, 10.0F);

		Invoke ("load_2", 5);

		if(isset_2)
			GUI.DrawTexture (new Rect ((Screen.width/2)-(450), (Screen.height/2)-(500), 931, 1024), another, ScaleMode.StretchToFill, true, 10.0F);

	}

	public void load()
	{
		isset = true;
	}

	public void load_2()
	{
		isset_2 = true;
	}

}
