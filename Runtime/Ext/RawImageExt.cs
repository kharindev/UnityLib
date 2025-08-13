using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public static class RawImageExt 
{
    public static void LoadFromWeb(this RawImage rawImage,MonoBehaviour coroutine, string url)
    {
        coroutine.StartCoroutine(DownloadImage(url, rawImage));
    }
    
    
    private static IEnumerator DownloadImage(string url,RawImage img)
    {
        var www = UnityWebRequestTexture.GetTexture(url);
        yield return www.SendWebRequest();
        if (www.result == UnityWebRequest.Result.Success)
        {
            if (!img) yield break;
            var texture = DownloadHandlerTexture.GetContent(www);
            img.texture = texture;
        }
        else
        {
            Debug.Log("Failed to download image: " + www.error);
        }
    }
}
