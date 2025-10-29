using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuMethods : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("game");
    }

    public void QuitButton()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
