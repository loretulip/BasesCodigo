using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numero;
    int doble, triple;

    // Start is called before the first frame update
    void Start()
    {
        doble = numero * 2;
        triple = numero * 3;
        Debug.Log(doble);
        Debug.Log(triple);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
