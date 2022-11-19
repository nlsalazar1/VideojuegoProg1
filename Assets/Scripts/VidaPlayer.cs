using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{
    public float vida = 100;
    public Image barraDeVida;
    
    // Update is called once per frame
    void Update()
    {
        vida = Mathf.Clamp(vida,0,100); //usamos para que la vida no exeda ni baje a menos del minimo
        barraDeVida.fillAmount = vida / 100;
    }
}
