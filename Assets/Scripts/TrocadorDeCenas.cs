using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocadorDeCenas : MonoBehaviour
{
    public void SceneInGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SceneQuit()
    {
        Application.Quit();
    }

    public void SceneMenu()
    {
        SceneManager.LoadScene(0);
    }

    [SerializeField] GameObject canvasCredits;

    public void CanvasCreditos()
    {
        canvasCredits.SetActive(true);
    }

    public void CanvasCreditosFechar()
    {
        canvasCredits.SetActive(false);
    }
}
