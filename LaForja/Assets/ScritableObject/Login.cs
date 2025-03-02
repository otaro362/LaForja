using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "login", menuName = "Configuracion", order = 1)]
public class Login : ScriptableObject
{
    public string nickName;
    public string correo;
    public string contraseņa;
    public int seleccion;
    public int monedas;
}
