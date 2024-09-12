using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Circulo(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Circulo(float radio)
    {
        areaC = radio * radio * 3.14f;
        return areaC;
    }
}
