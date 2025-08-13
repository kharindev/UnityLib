using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class LoadSave {

    public static void Save<T>(T data, string fileName) {
        string path = Application.persistentDataPath + Path.DirectorySeparatorChar + fileName;
        try {
            using (FileStream stream = File.Open(path, FileMode.Create, FileAccess.Write)) {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, data);
                Debug.Log(">>> SAVED: " + path);
            }
        } catch (IOException e) {
            Debug.LogError("IO Exception during save: " + e.Message);
        }
    }

    public static T Load<T>(T def, string fileName) {
        string path = Application.persistentDataPath + Path.DirectorySeparatorChar + fileName;

        if (!File.Exists(path)) {
            Debug.LogWarning(">>> LOAD: File does not exist: " + path);
            return def;
        }

        FileInfo fileInfo = new FileInfo(path);
        if (fileInfo.Length == 0) {
            Debug.LogWarning(">>> LOAD: File is empty: " + path);
            return def;
        }

        try {
            using (FileStream stream = File.OpenRead(path)) {
                BinaryFormatter formatter = new BinaryFormatter();
                T data = (T)formatter.Deserialize(stream);
                Debug.Log(">>> LOADED: " + path);
                return data;
            }
        } catch (SerializationException e) {
            Debug.LogError("SerializationException: " + e.Message);
        } catch (IOException e) {
            Debug.LogError("IOException: " + e.Message);
        } catch (System.Exception e) {
            Debug.LogError("Unknown exception: " + e.Message);
        }

        return def;
    }
}