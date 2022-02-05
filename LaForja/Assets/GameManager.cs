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
    public TMP_InputField contraseña;
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
            contraseña.text = loginScr.contraseña;
        }
        else
        {
            nickname.text = null;
            correo.text = null;
            contraseña.text = null;
        }
    }
    public void InicioSecion()
    {
        loginScr.nickName=nickname.text;
        loginScr.correo=correo.text;
        loginScr.contraseña=contraseña.text;
        aniPanel.SetBool("Panel", true);
        StartCoroutine("CargaEscena");
    }
    IEnumerator CargaEscena()
    {
        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene(seleccionPersonaje);
    }
}
