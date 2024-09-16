using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntuacion1 = 30;
    int puntuacion2 = 46;
    int puntuacion3 = 912;

    int sumaPuntuaciones;
    float mediaPuntuaciones;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Puntuación 1: " + puntuacion1);
        Debug.Log("Puntuación 2: " + puntuacion2);
        Debug.Log("Puntuación 3: " + puntuacion3);
        sumaPuntuaciones = puntuacion1 + puntuacion2 + puntuacion3;
        mediaPuntuaciones = sumaPuntuaciones / 3;
        Debug.Log("Media puntuaciones: " + mediaPuntuaciones);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
