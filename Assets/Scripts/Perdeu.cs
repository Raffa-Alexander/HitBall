using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    public GameObject canvasGameOver;
    public GameObject canvasInGame;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canvasGameOver.SetActive(true);
        canvasInGame.SetActive(false);
        Pontuacao();
    }

    int points;
    int maxPoints;
    public Plataforma platform;
    public Text textMaxPoints;

    public void Pontuacao()
    {
        points = platform.ReturnPoints();
        maxPoints = PlayerPrefs.GetInt("PontuacaoSalva");

        if(points > maxPoints)
        {
            PlayerPrefs.SetInt("PontuacaoSalva", points);

            maxPoints = points;
        }

        textMaxPoints.text = maxPoints.ToString();
    }
}
