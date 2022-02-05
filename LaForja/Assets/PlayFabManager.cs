using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;

public class PlayFabManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Login();
    }

    void Login()
    {
        var request = new LoginWithCustomIDRequest
        { CustomId=SystemInfo.deviceUniqueIdentifier,CreateAccount=true};
        PlayFabClientAPI.LoginWithCustomID(request, OnSuccess, OnError);
    }
    void OnSuccess(LoginResult result)
    {
        Debug.Log("inicio de secion");
    }
    void OnError(PlayFabError error)
    {
        Debug.Log("error al iniciar seccion");
        Debug.Log(error.GenerateErrorReport());
    }
    public void SendLeaderboard(int puntaje)
    {
        var request = new UpdatePlayerStatisticsRequest
        {
            Statistics = new List<StatisticUpdate>
            {
                new StatisticUpdate
                {
                    StatisticName="CalificacionArma",
                    Value=puntaje
                }
            }
        };
        PlayFabClientAPI.UpdatePlayerStatistics(request, OnLeaderboardUpdate, OnError);
    }
    void OnLeaderboardUpdate(UpdatePlayerStatisticsResult result)
    {
        Debug.Log("estadisticas enviadas a leaderboard");
    }
    public void GetLeaerboard()
    {
        var request = new GetLeaderboardRequest
        {
            StatisticName = "CalificacionArma",
            StartPosition = 0,
            MaxResultsCount = 10
        };
        PlayFabClientAPI.GetLeaderboard(request, OnleaderboardGet, OnError);

    }
    void OnleaderboardGet(GetLeaderboardResult result)
    {
        foreach (var item in result.Leaderboard)
        {
            Debug.Log(item.Position + "  " + item.PlayFabId + "  " + item.StatValue);
        }
    }
}
