using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosJuegoControl : MonoBehaviour
{
    private int puntuacion;

    public int Puntuacion { get => puntuacion; set => puntuacion = value; }
    private void Awake()
    {
        //�cu�ntas instancias hay? 
        int numeroInstancias = FindObjectsOfType<DatosJuegoControl>().Length;
        //si hay m�s de una, es por que se ha recargado la escena, destrimos la  nueva instancia
        if (numeroInstancias != 1) Destroy(this.gameObject);
        //this representa la instancia de DatosJuegosControl que se est� ejecutando
        else DontDestroyOnLoad(this.gameObject);

    }
}
