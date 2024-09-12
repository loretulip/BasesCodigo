using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float velocidadKmh;
    float velocidadMs;
    // Start is called before the first frame update
    void Start()
    {
        velocidadMs = velocidadKmh / 3.6f;
        Debug.Log(velocidadMs);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
