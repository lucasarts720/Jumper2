using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tuto0 : MonoBehaviour
{

    public Text tuto;
    public string dice;
    void Start()
    {
        tuto.text = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            tuto.text = dice;
        }
    }
}

