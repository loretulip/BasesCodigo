using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int nivel;
    int ataques;
    // Start is called before the first frame update
    void Start()
    {
        
        if(nivel%10==0)
        {
            Debug.Log("Es m�ltiplo de 10");
        }
        else
        {
            Debug.Log("No es m�ltiplo de 10");

        }
        ataques=nivel/10;
        Debug.Log("Aprendi� "+ataques+" ataques.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
