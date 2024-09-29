using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_1 : MonoBehaviour
{
    private string nombre;
    private float vida;
    private float exp;

    public string Nombre { get => nombre; set => nombre = value; }
    public float Vida { get => vida; set => vida = value; }
    public float Exp { get => exp; set => exp = value; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float CalcularNivel()
    {
        return exp / 1000f;
    }
}
