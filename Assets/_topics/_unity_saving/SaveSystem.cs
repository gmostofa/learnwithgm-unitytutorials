using System.IO;
using UnityEngine;

public static class SaveSystem
{
    public static string path = Application.persistentDataPath + "/save.json";

    public static void Save(PlayerData data)
    {
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(path,json);
        
        Debug.Log(Application.persistentDataPath);
        Debug.Log(json);
    }

    public static PlayerData Load()
    {
        if (!File.Exists(path)) return null;
        string json = File.ReadAllText(path);
        return JsonUtility.FromJson<PlayerData>(json);
    }
}
