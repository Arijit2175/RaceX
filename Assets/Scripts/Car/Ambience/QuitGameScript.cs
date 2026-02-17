using UnityEngine;

public class QuitGameScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }
    }

    void QuitGame()
    {
        Application.Quit();
        Debug.Log("QuitGame() called - Pressed Escape");
    }
}
