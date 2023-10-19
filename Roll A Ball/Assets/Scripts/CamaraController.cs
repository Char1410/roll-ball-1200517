using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CamaraController : MonoBehaviour
{
    //Referencia a nuestro jugador
    public GameObject jugador;
    //Para registrar la diferencia entre la posici�n de la c�mara y la del jugador
    private Vector3 offset;
    // Use this for initialization
    void Start()
    {
        //diferencia entre la posici�n de la c�mara y la del jugador
        offset = transform.position - jugador.transform.position;
    }
void LateUpdate()
    {
        //Actualizo la posici�n de la c�mara
        transform.position = jugador.transform.position + offset;
    }
}
