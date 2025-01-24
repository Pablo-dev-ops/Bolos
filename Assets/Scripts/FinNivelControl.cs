using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinNivelControl : MonoBehaviour
{
    private DatosJuegoControl datosJuego;
    public TextMeshProUGUI mensajeFinalTxt;

    void Start()
    {
        datosJuego = GameObject.Find("DatosJuego").GetComponent<DatosJuegoControl>();
        //para gestionar el mensaje que se presenta 
        string mensajeFinal = "Has tirado " + datosJuego.Puntuacion + " bolos.";
        //se asigna al texto del mensaje en la escena 
        mensajeFinalTxt.text = mensajeFinal;
    }
}
