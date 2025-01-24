using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlBotones : MonoBehaviour
{
    public Button botonJugar, botonSalir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BotonSalir()
    {
        Application.Quit();
    }
    public void BotonJugar()
    {
        SceneManager.LoadScene("Juego");
    }
}
