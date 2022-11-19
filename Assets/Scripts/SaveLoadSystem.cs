using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadSystem : MonoBehaviour
{
    [SerializeField]
    private InfoPlayer infoPlayer;
    // Start is called before the first frame update

    [ContextMenu("Save")] //para poderlo llamar desde el inspector mas rapidamente
    public void Save()
    {
        
        string infoPlayerJson = JsonUtility.ToJson(infoPlayer);
        Debug.Log(infoPlayerJson);
        //Ruta donde se guardara nuestro archivo
        string path = Path.Combine(Application.persistentDataPath + "playerData.data");
        File.WriteAllText(path,infoPlayerJson); //se escribira en el disco
        Debug.Log(path);
    }

    // Update is called once per frame
    [ContextMenu("Load")]
    public void Load()
    {
        string path = Path.Combine(Application.persistentDataPath + "playerData.data");
        string infoPlayerJson = File.ReadAllText(path);
        InfoPlayer infoPlayerLoaded = JsonUtility.FromJson<InfoPlayer>(infoPlayerJson);

        infoPlayer.Life = infoPlayerLoaded.Life;
        infoPlayer.Shield = infoPlayerLoaded.Shield;
        infoPlayer.Nombre = infoPlayerLoaded.Nombre;
    }
}
