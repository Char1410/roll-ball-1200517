using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody rb;
    public float velocidad;
    private int contador;
    public TMP_Text TextoContador, TextoGanar;
    public AudioSource audioSource;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;

        setTextoContador();

        TextoGanar.text = "";
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoH, 0.0f, movimientoV);

        rb.AddForce(movimiento*velocidad);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coleccionable"))
        {
            audioSource.Play();
            //Desactivo el objeto
            other.gameObject.SetActive(false);
            //Incremento el contador en uno (también se peude hacer como contador++)
            contador = contador + 1;
            setTextoContador();

        }
    }

    void setTextoContador()
    {
        TextoContador.text = "Contador: " + contador.ToString();
        if (contador >= 12)
        {
            TextoGanar.text = "¡Ganaste!";
        }
    }


}
