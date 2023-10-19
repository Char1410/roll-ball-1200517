using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void Main()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Controles()
    {
        SceneManager.LoadScene("Controles");
    }



    public void Salir()
    {
        Application.Quit();
    }
}
