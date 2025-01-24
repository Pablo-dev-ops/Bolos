using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuentaBolos : MonoBehaviour
{
    public DatosJuegoControl dTJC;

    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dTJC.Puntuacion = score;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bolo")) score++;

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Bolo")) score--;

    }
}
