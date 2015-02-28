using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

    public bool canMove;
    public Movement mouvements;
	public int range;
	public int damage;



    private SpriteRenderer spriteRenderer;
    private GameObject enemy;
	private bool spawned;

	// Use this for initialization
	void Start () {
        spawned = false;
        DansLaChampDeLaCamera();
	}
	
	// Update is called once per frame
	void Update () {
        /*if (spawned)
        {
            int posX = mouvements.posX;
            int posY = mouvements.posY;

            if (Input.GetAxis("Horizontal") == 1)
            {
                mouvements.Move('d', posX, posY);
            }

            if (Input.GetAxis("Horizontal") == -1)
            {
                mouvements.Move('g', posX, posY);
            }

            if (Input.GetAxis("Vertical") == 1)
            {
                mouvements.Move('h', posX, posY);
            }

            if (Input.GetAxis("Vertical") == -1)
            {
                mouvements.Move('b', posX, posY);
            }
        }
        */
	}

	public void Move()
	{
		int posX = mouvements.posX;
		int posY = mouvements.posY;
		mouvements.Move('d', posX, posY);
	}



    public void DansLaChampDeLaCamera()
    {
        if (renderer.IsVisibleFrom(Camera.main))
        {
            spawned = true;
        }
    }
}
