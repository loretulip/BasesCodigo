using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float velocidad1 = 100;
        float velocidadEnMS1=ConvertirKmHaMS(velocidad1);
        Debug.Log(velocidad1 + " Km/h son " + velocidadEnMS1 + " m/s.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float ConvertirKmHaMS(float vel)
    {
        return vel * 1000 / 3600;
    }
}
