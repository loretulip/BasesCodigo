using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 10;
    float exp = 3.3f;
    char carac = 'a';

    float resultadoSuma;
    float resultadoResta;

    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vidas);
        Debug.Log(exp);
        resultadoSuma = vidas + exp;
        resultadoResta = exp - vidas;
        Debug.Log(resultadoSuma);
        Debug.Log(resultadoResta);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
