using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMovement : MonoBehaviour
{

    public float velocidade;
    public float velocidadeInicial;
    public float aceleracao;
    void Start()
    {
        velocidade = velocidadeInicial;
    }

    void Update()
    {
            velocidade += aceleracao * Time.deltaTime;
            transform.position += new Vector3(1 * velocidade * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D player)
    {
        if(player.gameObject.CompareTag("Player"))
        {
            KillPlayer(player.gameObject);
        }
    }
    private void KillPlayer(GameObject player)
    {
        Destroy(player);
        Time.timeScale = 0;
        SceneManager.LoadScene("TryAgain");
    }
}