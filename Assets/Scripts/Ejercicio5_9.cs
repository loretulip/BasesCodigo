using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField] int tipo;
    // Start is called before the first frame update
    void Start()
    {
        if (tipo == 1)
        {
            Debug.Log("Da�o: 350 | Vida: 650");
        }
        else if (tipo == 2)
        {
            Debug.Log("Da�o: 300 | Vida: 550");
        }
        else if (tipo == 3)
        {
            Debug.Log("Da�o: 300 | Vida: 500");
        }
        else if (tipo == 4)
        {
            Debug.Log("Da�o: 310 | Vida: 460");
        }
        else if (tipo == 5)
        {
            Debug.Log("Da�o: 280 | Vida: 490");
        }
        else if (tipo == 6)
        {
            Debug.Log("Da�o: 360 | Vida: 520");
        }
        else
        {
            Debug.Log("Ese tipo no existe");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
