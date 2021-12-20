using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

    public class ControlJugador : MonoBehaviour
{
    private Rigidbody rb;
    public int CantidadARecolectar = 5;
    public int rapidez;
    public Text textoCantidadRecolectados;
    private int cont;
    public string Dice = "Cantidad Recolectados: ";
    public string TagAComparar = "coleccionable";
    public GameObject Panel;
    public bool MovementEnabled = true;
   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cont = 0;
        ColectarOro();
    }

    private void ColectarOro()
    {
        textoCantidadRecolectados.text = Dice + cont.ToString() + " de " + CantidadARecolectar.ToString();
        if (cont >= CantidadARecolectar)
        {
            Panel.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            MovementEnabled = false;
        }
    }

    private void Update()
    {
        if (MovementEnabled)
        {
            float movimientoAdelanteAtras = Input.GetAxis("Vertical") * rapidez;
            float movimientoCostados = Input.GetAxis("Horizontal") * rapidez;

            movimientoAdelanteAtras *= Time.deltaTime;
            movimientoCostados *= Time.deltaTime;

            transform.Translate(movimientoCostados, 0, movimientoAdelanteAtras);
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