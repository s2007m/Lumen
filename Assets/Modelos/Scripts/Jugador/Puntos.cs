/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VidaJugador : MonoBehaviour
{
    public int pts = 0;

    public Text textoPts;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Enemigo1" || other.name == "Enemigo1(Clone)")
        {
            pts = pts + 5;

            textoPts.text = " " + pts;

            if (vida <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        else if (other.name == "Enemigo2" || other.name == "Enemigo2(Clone)")
        {
            vida = vida - 10;

            textoVida.text = "           " + vida;

            if (vida <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        else if (other.name == "Enemigo3" || other.name == "Enemigo3(Clone)")
        {
            vida = vida - 15;

            textoVida.text = "           " + vida;

            if (vida <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    int pts;
    public Text TextoPts;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            pts += 5;
            TextoPts.text = "" + pts;
        }
    }
}*/
