using UnityEditor;
using UnityEngine;

public class DirectoryCleaner 
{
    public static void ClearDirectory(string directoryPath)
    {
        if (string.IsNullOrEmpty(directoryPath))
        {
            Debug.LogError("Directory path is not set.");
            return;
        }

        if (!System.IO.Directory.Exists(directoryPath))
        {
            Debug.LogWarning("Directory does not exist: " + directoryPath);
            return;
        }

        var files = System.IO.Directory.GetFiles(directoryPath);
        var dirs = System.IO.Directory.GetDirectories(directoryPath);

        foreach (var file in files)
        {
            FileUtil.DeleteFileOrDirectory(file);
        }

        foreach (var dir in dirs)
        {
            FileUtil.DeleteFileOrDirectory(dir);
        }

        Debug.Log("Directory cleared: " + directoryPath);
    }
}