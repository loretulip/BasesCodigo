using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CreadorPersonajes : MonoBehaviour
{
    [SerializeField] int numero = 4;
    string texto = "Hola";
    float decima = 3.4f;
    [SerializeField] Personaje link;
    [SerializeField] Personaje mario;
    
    // Start is called before the first frame update
    void Start()
    {
        //link.Vida = 100;
        //link.Nombre = "Link";
        //link.Atacar();
        //link.Saltar();
        //link.Mover(1, 2, 3);
    }        
}
