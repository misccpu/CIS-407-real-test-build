using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUI : MonoBehaviour
{
    // For now, 'health' refers to the enemy's 'package' of bp/mp/sp.
    // BP is index 0, MP is 1, and SP is 2.
    float[] max_health = new float[3] { 50, 50, 50 };                // max bp/mp/sp values
    float[] current_health = new float[3] { 50, 50, 50 };            // current bp/mp/sp values
    public GenericHealthBar[] health_bar = new GenericHealthBar[3]; // ties values to health bars in UI

    private void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            current_health[i] = max_health[i];          // sets current health to max
            health_bar[i].SetValue(max_health[i]);      // makes the health bars match
            health_bar[i].SetMaxValue(max_health[i]);
        }
    }

    private void Update()   // currently only updates health on appropriate keydown
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(0, 20);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1, 20);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(2, 20);
        }
    }

    void TakeDamage(int i, float amount)
    {
        current_health[i] -= amount;
        if (current_health[i] < 0)
        {
            current_health[i] = 0;
        }
        health_bar[i].SetValue(current_health[i]);
    }

    void Heal(int i, float amount)
    {
        current_health[i] += amount;
        if (current_health[i] >= max_health[i])
        {
            current_health[i] = max_health[i];
        }
        health_bar[i].SetValue(current_health[i]);
    }
}
