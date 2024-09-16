using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] float radio;
    float longitud, area;
    // Start is called before the first frame update
    void Start()
    {
        longitud = 2 * 3.14f * radio;
        area = 3.14f * radio*radio;
        Debug.Log("Longitud: " + longitud);
        Debug.Log("Radio: " + radio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
