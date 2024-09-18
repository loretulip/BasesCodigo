using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int Dorothy, Kiara, Connor;

    // Start is called before the first frame update
    void Start()
    {
        if (Dorothy > Kiara && Dorothy > Connor)
        {
            if (Kiara > Connor)
            {
                Debug.Log("Primero: Dorothy, Segundo: Kiara, Tercero: Connor");
            }
            else
            {
                Debug.Log("Primero: Dorothy, Segundo: Connor, Tercero: Kiara");
            }
        }
        else if (Kiara > Connor && Kiara > Dorothy)
        {
            if (Dorothy > Connor)
            {
                Debug.Log("Primero: Kiara, Segundo: Dorothy, Tercero: Connor");
            }
            else
            {
                Debug.Log("Primero: Kiara, Segundo: Connor, Tercero: Dorothy");
            }
        }
        else if (Connor > Dorothy && Connor > Kiara)
        {
            if (Kiara > Dorothy)
            {
                Debug.Log("Primero: Connor, Segundo: Kiara, Tercero: Dorothy");
            }
            else
            {
                Debug.Log("Primero: Connor, Segundo: Dorothy, Tercero: Kiara");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

