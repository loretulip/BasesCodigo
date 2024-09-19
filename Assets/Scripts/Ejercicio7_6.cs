using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int num1, num2;
    int contar;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 >= 0 && num2 >= 0) 
        {
            while (num2 > num1)
            {
                num1++;
                Debug.Log(contar);
            }

            for (int contar = num1; contar < num2; contar++)
            {
                Debug.Log(contar);
            }
        }
        else
        {
            Debug.Log("Tiene que ser un número positivo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
