using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int H, M, S;
    // Start is called before the first frame update
    void Start()
    {
        if (H <= 23 && H >= 0 && M <= 59 && M >= 0 && S <= 59 && S >= 0) 
        {
            Debug.Log("Son las: "+H+":"+M+":"+S);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
