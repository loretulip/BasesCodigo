using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float vida = 120;

    int ronda = 0;
    int dano = 3;

    // Start is called before the first frame update
    void Start()
    {
        while (ronda <= 5)
        {
            vida = vida - vida * 0.3f + ronda * dano;
            Debug.Log("Vida: " + vida);
            ronda++;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
