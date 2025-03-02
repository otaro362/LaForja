using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public TMP_InputField nickname;
    public TMP_InputField correo;
    public TMP_InputField contraseņa;
    public Toggle recuerdame;
    public Login loginScr;
    public Animator aniPanel;
    public string seleccionPersonaje;
    public void Start()
    {
        if (recuerdame.isOn == true)
        {
            nickname.text = loginScr.nickName;
            correo.text = loginScr.correo;
            contraseņa.text = loginScr.contraseņa;
        }
        else
        {
            nickname.text = null;
            correo.text = null;
            contraseņa.text = null;
        }
    }
    public void InicioSecion()
    {
        loginScr.nickName=nickname.text;
        loginScr.correo=correo.text;
        loginScr.contraseņa=contraseņa.text;
        aniPanel.SetBool("Panel", true);
        StartCoroutine("CargaEscena");
    }
    IEnumerator CargaEscena()
    {
        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene(seleccionPersonaje);
    }
}
