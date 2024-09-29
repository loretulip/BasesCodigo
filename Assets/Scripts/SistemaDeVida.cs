using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeVida : MonoBehaviour
{
    [SerializeField] private float vidaInicial;
     float vidaActual;
    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaInicial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float RecibirCura(float cantidad)
    {
        if (cantidad < 0) return -1;
        vidaActual += cantidad;
        return vidaActual;
    }

    public float RecibirDanho(float danho)
    {
        if (danho < 0) return -1;
        vidaActual -= danho;
        return vidaActual > 0 ? vidaActual : 0;
    }
}
