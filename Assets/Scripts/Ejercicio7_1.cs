using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_1 : MonoBehaviour
{
    int contar=0;
    // Start is called before the first frame update
    void Start()
    {
        while (contar<100)
        {
            contar++;
            Debug.Log(contar);            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
