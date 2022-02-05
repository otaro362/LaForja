using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayFabManager playFabManager;
    public int puntajeFinal;
    void Start()
    {
        playFabManager = GameObject.Find("PlayFabManager").GetComponent<PlayFabManager>();
    }
    public void Resultados(int puntaje)
    {
        puntajeFinal = puntaje;
    }
    public void GameOver()
    {
        playFabManager.SendLeaderboard(puntajeFinal);
    }
}
