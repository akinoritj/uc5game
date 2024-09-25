using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Função : MonoBehaviour
{
    public void PlayGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Fase1");
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
