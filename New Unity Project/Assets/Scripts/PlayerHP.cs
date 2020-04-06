using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    


    public Slider playerSlider;
    public void SetMaxEnemyHealth(int phealth)
    {
        playerSlider.maxValue = phealth;
        playerSlider.value = phealth;
    }


    public void SetHealth(float phealth)
    {
        playerSlider.value = phealth;
    }

}
