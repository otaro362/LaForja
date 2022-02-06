using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Jugadores : MonoBehaviour
{
    public TMP_Text jugadores;
    public float time;
    public int jugadoresconectados;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time>=2)
        {
            jugadores.text = ("jugadores conectados " + jugadoresconectados);
            jugadoresconectados++;
            time = 0;
        }
        if (jugadoresconectados==4)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
