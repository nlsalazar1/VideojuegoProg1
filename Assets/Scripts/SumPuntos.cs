using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SumPuntos : MonoBehaviour
{
    public int puntuacion;
    public Text pts;//Objeto Canvas-Text que vamos a usar para el puntaje

    void Awake()
    {
        puntuacion = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        actualizarPuntos();
    }

    private void OnTriggerEnter(Collider obj)
    {
        //obj.gameObject.SetActive(false); //desactiva el objeto que reciba ese momento
        if(obj.CompareTag("MenosPunto"))
        {
            Destroy(obj.gameObject);
            Debug.Log("Colision");
            puntuacion--;
            actualizarPuntos();
        }
        if(obj.CompareTag("masPunto"))
        {
            Destroy(obj.gameObject);
            Debug.Log("Colision");
            puntuacion++;
            actualizarPuntos();
        }
        
    }

    void actualizarPuntos()
    {
        pts.text = "Puntos = "+ puntuacion.ToString();
    }
}
