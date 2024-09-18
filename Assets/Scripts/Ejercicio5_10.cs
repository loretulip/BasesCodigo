using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    [SerializeField] float temp;
    // Start is called before the first frame update
    void Start()
    {
        if (temp <= 10)
        {
            Debug.Log("Frío");
        }
        else if (10 < temp || temp <= 20)
        {
            Debug.Log("Nublado");
        }
         else if (20 < temp || temp <= 30)
        {
            Debug.Log("Caluroso");
        }
         else if (temp>30)
        {
            Debug.Log("Tropical");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
