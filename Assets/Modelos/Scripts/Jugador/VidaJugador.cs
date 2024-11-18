using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VidaJugador : MonoBehaviour
{
    public int vida = 100;
    public GameObject panelDanio;
    public float danioDuracion = 0.8f;
    public Text textoVida;

    public void Start()
    {
        panelDanio.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Enemigo1" || other.name == "Enemigo1(Clone)")
        {
            vida = vida - 5;
            StartCoroutine(MostrarPanelDanio());
            textoVida.text = "           " + vida;

            if (vida <= 0)
            {
                Jugador.Estado = "Idle";
                SceneManager.LoadScene("GameOver");
            }
        }   
        else if (other.name == "Enemigo2" || other.name == "Enemigo2(Clone)")
        {
            vida = vida - 10;
            StartCoroutine(MostrarPanelDanio());
            textoVida.text = "           " + vida;

            if (vida <= 0)
            {
                Jugador.Estado = "Idle";
                SceneManager.LoadScene("GameOver");
            }
        }
              else if (other.name == "Enemigo3" || other.name == "Enemigo3(Clone)")
        {
                  vida = vida - 15;
                  StartCoroutine(MostrarPanelDanio());
                  textoVida.text = "           " + vida;

                  if (vida <= 0)
                  {
                        Jugador.Estado = "Idle";
                        SceneManager.LoadScene("GameOver");
                  }
              }
    }
    private IEnumerator MostrarPanelDanio()
    {
        panelDanio.SetActive(true);
        yield return new WaitForSeconds(danioDuracion);
        panelDanio.SetActive(false);
    }
}
