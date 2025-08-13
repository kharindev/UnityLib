using MyLib.UI;
using UnityEngine;

public class GameState
{
    private static bool IsWindowPause => WindowUIManager.HasOpenWindows;
    private static bool _isPause = false;
    private static bool _adPause = false;
    public static bool GamePause
    {
        set
        {
            if(_adPause) return;
            if (value) SetPause();
            else SetResume();
        }
    }
    
    public static bool AdPause
    {
        set
        {
            _adPause = value;
            if (value) SetPause();
            else SetResume();
        }
    }

    private static void SetPause()
    {
        if(Pause) return;
        Pause = true;
    }
    
    private static void SetResume()
    {
        if(!Pause) return;
        Pause = IsWindowPause;
    }

    private static bool Pause
    {
        set
        {
            _isPause = value;
            Time.timeScale = value ? 0 : 1;
        }
        get => _isPause;
    }
    
    
}
