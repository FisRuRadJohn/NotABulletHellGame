using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    public Slider enemySlider;

    public void SetMaxEnemyHealth(int health)
    {
        enemySlider.maxValue = health;
        enemySlider.value = health;
    }


    public void SetHealth(float health)
    {
        enemySlider.value = health;
    }
}
