using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1 = 10;
    int vidasPlayer2 = 16;
    int vidasPlayer3 = 5;
    int vidasPlayer4 = 90;

    int vidaFinalPlayer1;
    int vidaFinalPlayer2;
    int vidaFinalPlayer3;
    int vidaFinalPlayer4;
    
    // Start is called before the first frame update
    void Start()
    {
        vidasPlayer2 = vidasPlayer3;
        vidaFinalPlayer2 = vidasPlayer2;

        vidasPlayer3 = vidasPlayer1;
        vidaFinalPlayer3 = vidasPlayer3;

        vidasPlayer1 = vidasPlayer4;
        vidaFinalPlayer1=vidasPlayer1;

        vidasPlayer4 = vidasPlayer2;
        vidaFinalPlayer4 = vidasPlayer4;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
