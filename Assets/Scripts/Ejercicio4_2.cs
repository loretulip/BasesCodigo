using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string salidaNombre = ConstruirNombre("Pepe","Ramírez","Fernández",89);
        Debug.Log("La persona se llama " + salidaNombre);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string ConstruirNombre(string nombre, string apellido1, string apellido2, int edad)
    {    
        string infoPersona = nombre + " " + apellido1 + " " + apellido2 + " " + edad;
        return infoPersona; 
    }

}
