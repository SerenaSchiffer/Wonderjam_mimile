using UnityEngine;
using System.Collections;

/// <summary>
/// Start or quit the game
/// </summary>
public class GameOverScript : MonoBehaviour
{
    public bool isDead;

    void OnGUI()
    {
        const int buttonWidth = 120;
        const int buttonHeight = 60;

        if (isDead)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - (buttonWidth / 2), (1 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight), "Retry the level!"))
            {
                //Reload the level
                Application.LoadLevel(Application.loadedLevelName);
            }

            if (GUI.Button(new Rect(Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight), "Back to menu"))
            {
                //Reload the level
                Application.LoadLevel("menu");

            }
        }


    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
