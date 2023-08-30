using UnityEngine;

public class PauseController : MonoBehaviour
{
    public static bool paused = true;

    

    public void Pause()
    {
        if(paused)
        {
            SetUnpause();
        }
        else
        {
            SetPause();
        }
    }


    private void SetPause()
    {
        Time.timeScale = 0;
        paused = true;
    }


    private void SetUnpause()
    {
        Time.timeScale = 1;
        paused = false;
    }
}