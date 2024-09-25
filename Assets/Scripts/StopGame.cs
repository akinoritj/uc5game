using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StopGame : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D player)
    {
        if(player.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("FFase2");
        }
    }
}
