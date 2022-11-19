using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerEscena : MonoBehaviour
{
    public float tiempo_star = 0;
    public float tiempo_end = 0;
    public string escena = " ";

    public Text texto;

    public void Update()
    {
        tiempo_star+=Time.deltaTime;

        //float t = float.Parse(int.Parse(tiempo_star));

        if(tiempo_star< tiempo_end)
        {
            texto.text = "Time: " + tiempo_star.ToString();
        }
        if(tiempo_star>= tiempo_end)
        {
        Application.LoadLevel(escena);
        }
    }
}
