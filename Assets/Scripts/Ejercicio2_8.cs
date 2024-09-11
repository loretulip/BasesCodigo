using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float vida = 120;

    int ronda = 1;
    int dano=3;
    
    // Start is called before the first frame update
    void Start()
    {
        while(ronda<=5)
        vida = vida - vida * 0.3f;
        Debug.Log("Vida: " + vida);
        vida = vida - vida * 0.6f;
        Debug.Log("Vida: " + vida);
        vida = vida - vida * 0.9f;
        Debug.Log("Vida: " + vida);
        vida = vida - vida * 0.12f;
        Debug.Log("Vida: " + vida);
        vida = vida - vida * 0.15f;
        Debug.Log("Vida: " + vida);       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
