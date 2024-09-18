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
            Debug.Log("Es múltiplo de 10");
        }
        else
        {
            Debug.Log("No es múltiplo de 10");

        }
        ataques=nivel/10;
        Debug.Log("Aprendió "+ataques+" ataques.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
