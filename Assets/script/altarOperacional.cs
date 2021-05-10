using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altarOperacional : MonoBehaviour
{

    public void OnTriggerEnter2D()
    {
        Debug.log ("Entrou")
    }

    public void OnTriggerStay2D()
    {
        Debug.log ("Ficou")
    }

    public void OntriggerExit2D()
    {
        Debug.log ("Saiu")
    }
}
