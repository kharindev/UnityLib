using UnityEditor;
using UnityEngine;
#if UNITY_EDITOR
public class ScreenshotTaker : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.Space))
        {
            TakeScreenshot();
        }
    }

    [MenuItem("Tools/Take Screenshot &Space")]
    public static void TakeScreenshot()
    {
        var filename = "Screenshot_" + System.DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".png";
        ScreenCapture.CaptureScreenshot(filename);
        Debug.Log("Screenshot saved as: " + filename);
    }
}
#endif
