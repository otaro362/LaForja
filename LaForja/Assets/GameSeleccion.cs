using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameSeleccion : MonoBehaviour
{
    public Login loginInfo;
    public TMP_Text nickname;
    public TMP_Text monedasString;
    public GameObject[] personaje;
    public Image peronajeUI;
    public Sprite[] personajeFoto;
    public int seleccion;
    public Animator[] aniPersonaje;

    public void Awake()
    {
        nickname.text = loginInfo.nickName;
        monedasString.text =loginInfo.monedas.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < personaje.Length; i++)
        {
            personaje[i].SetActive(false);
            personaje[seleccion].SetActive(true);
            peronajeUI.sprite = personajeFoto[seleccion];
        }
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void Seleccion()
    {
        loginInfo.seleccion = seleccion;
        aniPersonaje[seleccion].SetBool("Seleccionado", true);

    }
    public void Siguiente()
    {
        seleccion++;
        if (seleccion>=3)
        {
            seleccion = 0;
        }
        for (int i = 0; i < personaje.Length; i++)
        {
            personaje[i].SetActive(false);
            personaje[seleccion].SetActive(true);
            peronajeUI.sprite = personajeFoto[seleccion];
        }

    }
    public void Anterior()
    {
        seleccion--;
        if (seleccion <0)
        {
            seleccion = 2;
        }
        for (int i = 0; i < personaje.Length; i++)
        {
            personaje[i].SetActive(false);
            personaje[seleccion].SetActive(true);
            peronajeUI.sprite = personajeFoto[seleccion];
        }

    }
}
