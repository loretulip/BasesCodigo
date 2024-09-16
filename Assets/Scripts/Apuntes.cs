using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apuntes : MonoBehaviour
{
    [SerializeField] bool carnetConducir;
    // Start is called before the first frame update
    void Start()
    {
        if (carnetConducir==true)
        {
            Debug.Log("Puedes conducir");
        }
        else
        {
            Debug.Log("No puedes conducir");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
