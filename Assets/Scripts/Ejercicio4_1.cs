using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Circulo(2);
        Triangulo(4.4f)
        Cuadrado(39);
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
    void Triangulo(float base, float altura)
    {
        areaT = (base * altura) / 2;
        return areaT;
    }
    void Cuadrado(float lado)
    {
        areaCu= lado*2
        return areaCu;
    }
}
