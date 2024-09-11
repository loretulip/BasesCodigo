using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_1 : MonoBehaviour
{        

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Este es el primer videojuego de Lorena");
        Debug.Log("Hola mundo");
        Debug.Log("Estoy aprendiendo C#");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado un frame"); //Este mensaje aparece constantemente porque la función Update se actualiza en cada frame mientras que el Start solo al inicio
    }
}
