using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float vidaTotal = 120;
    float vidaActual = 120;

    int ronda = 0;
    int dano = 3;

    // Start is called before the first frame update
    void Start()
    {
        while (ronda <= 4)
        {
            ronda++;
            vidaActual -=  vidaTotal * 0.03f;
            Debug.Log("Ronda: " + ronda + " | Vida: " + vidaActual);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
