using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntrarJuego : MonoBehaviour
{
    public string escena = " ";

    public void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(escena);
        
    }
}