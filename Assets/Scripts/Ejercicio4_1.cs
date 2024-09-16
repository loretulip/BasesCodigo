using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        float CalcCirculo = Circulo(2);
        float CalcTriangulo = Triangulo(4.4f, 3.3f);
        float CalcCuadrado = Cuadrado(39);
        Debug.Log("Área círculo: " + CalcCirculo);
        Debug.Log("Área triángulo: " + CalcTriangulo);
        Debug.Log("Área cuadrado: " + CalcCuadrado);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float Circulo(float radio)
    {
        float areaC = radio * radio * 3.14f;
        return areaC;
    }
    float Triangulo(float b, float altura)
    {
        float areaT = (b * altura) / 2;
        return areaT;
    }
    float Cuadrado(float lado)
    {
        float areaCu = lado * 2;
        return areaCu;
    }
}

