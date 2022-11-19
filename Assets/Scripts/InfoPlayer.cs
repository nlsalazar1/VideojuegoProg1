using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class InfoPlayer
{
    //public Text texto;
    public int Life;
    public int Shield;    
    public string Nombre = "";
    
     
    //private GameObject nombre1;

    public InfoPlayer()
    {
        //nombre1 = GameObject.FindGameObjectWithTag("nombre1");
        //nombre = PlayerPrefs.GetString("nombre1");
        Nombre = "";
        Life = 10;
        Shield = 10;
    }


    // Start is called before the first frame update
    private void Start()
    {
        
    }
}
