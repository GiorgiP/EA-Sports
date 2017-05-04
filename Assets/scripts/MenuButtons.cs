
using UnityEngine;
using UnityEngine.SceneManagement;



public class MenuButtons : MonoBehaviour
{

    int score;



    public void RestartGame()
    {

        SceneManager.LoadScene(0);

    }

    public void QuitGame()
    {

        Application.Quit();

    }
}
