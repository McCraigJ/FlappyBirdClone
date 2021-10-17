using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayTheGame()
    {
        SceneManager.LoadScene("Fish");
    }

    public void QuitTheGame()
    {
        Debug.Log("Quit the game");
        Application.Quit();
    }
}
