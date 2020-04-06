using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2HP : MonoBehaviour
{



    public Slider player2Slider;

    public void SetMaxP2Health(int phealth2)
    {
        player2Slider.maxValue = phealth2;
        player2Slider.value = phealth2;
    }


    public void SetHealth(float phealth2)
    {
        player2Slider.value = phealth2;
    }

}