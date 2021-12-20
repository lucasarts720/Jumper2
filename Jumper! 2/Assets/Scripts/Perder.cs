using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Perder : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") == true)
        {

            SceneManager.LoadScene("Muerte", LoadSceneMode.Single);
        }
    }
}
