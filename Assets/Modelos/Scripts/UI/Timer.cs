using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float tiempoInicial = 214f; 
    private float tiempoRestante; 

    public Text textoTiempo; 

    void Start()
    {
        tiempoRestante = tiempoInicial;
    }

    void Update()
    {
        if (tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime; 
            ActualizarTextoTiempo();
        }
        else
        {
            tiempoRestante = 0f;
            SceneManager.LoadScene("Ganaste");
        }
    }
    void ActualizarTextoTiempo()
    {
        int minutos = Mathf.FloorToInt(tiempoRestante / 60);
        int segundos = Mathf.FloorToInt(tiempoRestante % 60);

        textoTiempo.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }

}
