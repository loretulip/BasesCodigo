using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int num1,num2;
    // Start is called before the first frame update
    void Start()
    {
        if (num1<3 && num2<3)
        {
            Debug.Log(num1 + " y " + num2 + " son menores a 3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
