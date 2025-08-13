using UnityEngine;

public class MyUtils 
{
    private static Vector2 _tmp = new Vector2();
    public static Vector2 RandomPush(float min, float max)
    {
        return Random.insideUnitCircle.normalized * Random.Range(min, max);
    }
    
    public static Vector2 RandomUpPush(float min, float max)
    {
        _tmp.Set(Random.Range(-1f,1f), Random.Range(0.5f,1f));
        return _tmp * Random.Range(min, max);
    }

    public static Color Color256(float r, float g, float b, float a)
    {
        return new Color(r/255f, g/255f,b/255f,a/255f);
    }
    
    public static string ConvertSecondsToHHMMSS(float seconds)
    {
        int hours = Mathf.FloorToInt(seconds / 3600);
        int minutes = Mathf.FloorToInt((seconds % 3600) / 60);
        int secs = Mathf.FloorToInt(seconds % 60);

        return string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, secs);
    }
}
