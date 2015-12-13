using UnityEngine;
using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoadStatus : MonoBehaviour {

	public static void Save (GameStatus gameStatus) {
        
        string json = JsonUtility.ToJson(gameStatus);

        BinaryFormatter bf = new BinaryFormatter();
        Debug.Log("save:::" + Application.persistentDataPath + "/JsonSerializerTest.json");
        FileStream file = File.Create(Application.persistentDataPath + "/JsonSerializerTest.json");
        bf.Serialize(file, json);
        file.Close();
    }

    public static GameStatus Load()
    {
        BinaryFormatter bf = new BinaryFormatter();

        if (!File.Exists(Application.persistentDataPath + "/JsonSerializerTest.json"))
        {
            return null;
        }
        FileStream file = File.Open(Application.persistentDataPath + "/JsonSerializerTest.json", FileMode.Open);

        if (file.Length == 0)
        {
            return null;
        }

        string json = (string)bf.Deserialize(file);
        file.Close();

        if (json.Length > 0)
        {
            return JsonUtility.FromJson<GameStatus>(json);
        }

        return null;
    }
}
