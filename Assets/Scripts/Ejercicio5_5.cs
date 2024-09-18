using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    [SerializeField] int vida;
    // Start is called before the first frame update
    void Start()
    {
        if (vida%2==0)
        {
            Debug.Log("Es par");
        }
        else
        {
            Debug.Log("Es imapar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
