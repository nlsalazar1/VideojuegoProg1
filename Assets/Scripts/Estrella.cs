using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrella : MonoBehaviour
{
    public GameObject ObjPuntos;
    public float puntosQueDa;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            ObjPuntos.GetComponent<SistemaPuntos>().puntos += puntosQueDa;
        }
    }
}
