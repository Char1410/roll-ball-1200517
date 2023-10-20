using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public TMP_Text TextoGanar, TextoTimer;

    public float tiempoLimite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempoLimite >= 0)
        {
            tiempoLimite -= Time.deltaTime;
            TextoTimer.text = "Tiempo: " + tiempoLimite;
        }
        else
        {
            TextoGanar.text = "PERDISTE :(";
            Invoke("StopScene", 5.0f);
        }
    }

    void StopScene()
    {
        // Detener la escena y realizar acciones adicionales si es necesario.
        Time.timeScale = 1.0f; // Restablecer el tiempo a su valor normal.
        SceneManager.LoadScene("Menu"); // Cargar una escena diferente o reiniciar el juego.
    }
}
