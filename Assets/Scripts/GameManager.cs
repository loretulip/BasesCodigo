using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Ejercicio8_1 personaje1;
    [SerializeField] private Ejercicio8_1 personaje2;
    private bool yaEjecutado = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !yaEjecutado)
        {
            PrepararPersonajes();
            yaEjecutado = true;
        }
    }
    void PrepararPersonajes()
    {
        personaje1.Nombre = "Jugador 1";
        personaje1.Vida = 100f;
        personaje1.Exp = 1500f;

        personaje2.Nombre = "Jugador 2";
        personaje2.Vida = 120f;
        personaje2.Exp = 2000f;

        Debug.Log(personaje1.Nombre + " tiene nivel: " + personaje1.CalcularNivel());
        Debug.Log(personaje2.Nombre + " tiene nivel: " + personaje2.CalcularNivel());
    }
}
