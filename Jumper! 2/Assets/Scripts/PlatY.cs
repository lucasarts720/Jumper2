using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatY : MonoBehaviour
{

    bool tengoQueBajar = false;
    public int rapidez = 5;
    public int AlturaMaxima;
    public int AlturaMinima;

    void Update()
    {
        if (transform.position.y >= AlturaMaxima)
        {
            tengoQueBajar = true;
        }
        if (transform.position.y <= AlturaMinima)
        {
            tengoQueBajar = false;
        }

        if (tengoQueBajar)
        {
            Bajar();
        }
        else
        {
            Subir();
        }

    }

    void Subir()
    {
        transform.position += transform.up * rapidez * Time.deltaTime;
    }

    void Bajar()
    {
        transform.position -= transform.up * rapidez * Time.deltaTime;
    }
}
