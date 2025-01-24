using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlLanzamiento : MonoBehaviour
{
    public GameObject bola;
    public Rigidbody2D rbPivote;

    private Camera cam;
    private Rigidbody2D rbBola;
    private SpringJoint2D pivote;
    private bool presionando = false;

    // Start is called before the first frame update
    void Start()
    {
        //Inicializamos las variables que no tenemos asociadas mediante la interfaz de Unity
        rbBola = bola.GetComponent<Rigidbody2D>();
        pivote = bola.GetComponent<SpringJoint2D>();
        pivote.connectedBody = rbPivote;
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        //¿Donde se ha presionado?
        Vector2 posicion = Touchscreen.current.primaryTouch.position.ReadValue();
        //Debug.Log("Posicion[" + posicion + "]");
        Vector3 posicionGlobal = cam.ScreenToWorldPoint(posicion);

        if (rbBola == null)
            return;

        if (Touchscreen.current.primaryTouch.press.isPressed) //si hemos presionado
        {
            presionando = true;
            rbBola.isKinematic = true;
            rbBola.position=posicionGlobal;
        }
        else
        {
            if (presionando)
            {
                Invoke("LanzaBola", 0.2f);
                presionando = false;
            }
            else
                return;
        }
    }

    private void LanzaBola ()
    {
      rbBola.isKinematic=false;
        Invoke("CortarCuerda", 0.5f);

    }
    private void CortarCuerda()
    {
        pivote.enabled = false;
        rbPivote = null;
    }
}
