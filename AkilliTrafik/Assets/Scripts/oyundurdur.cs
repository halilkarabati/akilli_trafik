using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyundurdur : MonoBehaviour
{
   
    private bool isPaused = false;

    public void TogglePause()
    {
        isPaused = !isPaused; // Durumun tersini al (durdurulmuþsa devam ettir, devam ediyorsa durdur)

        if (isPaused)
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f; // Oyunu durdur
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; // Oyunu devam ettir
    }
}
