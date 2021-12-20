using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlJugador1 : MonoBehaviour
{
    private Rigidbody rb;
    public float CantidadARecolectar = 5;
    public int rapidez;
    public Text textoCantidadRecolectados;
    private int cont;
    public string Dice = "Cantidad Recolectados: ";
    public string CargarEscena = "Ganar";
    public string TagAComparar = "coleccionable";


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cont = 0;
        ColectarOro();
    }

    private void ColectarOro()
    {
        textoCantidadRecolectados.text = Dice + cont.ToString();
        if (cont >= CantidadARecolectar)
        {
            SceneManager.LoadScene(CargarEscena, LoadSceneMode.Single);
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.position += rb.transform.forward * rapidez * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.position += rb.transform.right * rapidez * -1f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.position += rb.transform.forward * rapidez * -1f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.position += rb.transform.right * rapidez * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(TagAComparar) == true)
        {
            cont = cont + 1;
            ColectarOro();
            other.gameObject.SetActive(false);
        }
    }
}