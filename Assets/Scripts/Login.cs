using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public InputField inputText;
    public Text nomJugador;
    public Image luz;
    public GameObject botonAceptar;

    private void Awake()
    {
        luz.color = Color.red;
    }

    // Update is called once per frame
    private void Update()
    {
        if(nomJugador.text.Length < 4)
        {
            luz.color = Color.red;
            botonAceptar.SetActive(false);
        }
        if(nomJugador.text.Length >= 4)
        {
            luz.color = Color.green;
            botonAceptar.SetActive(true);
        }
    }

    public void aceptar()
    {
        PlayerPrefs.SetString("nombre1", inputText.text);
        SceneManager.LoadScene("TerrenoArmado");
    }
}
