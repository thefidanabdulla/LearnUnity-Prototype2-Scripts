using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 3;

    private int currentHealth;

    public float healthPercentValue = 1;

    public PlayerController Player;

    private void OnEnable()
    {
        currentHealth = maxHealth;
    }

    public void ModifyHealth(int amount)
    {
        currentHealth += amount;

        healthPercentValue = (float)currentHealth / (float)maxHealth;        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name != "Player" || other.gameObject.name != "Pizza(Clone)")
        {
            ModifyHealth(-1);
        }
    }

    private void Update()
    {
        if(currentHealth == 0)
        {
            Destroy(gameObject);
            Player.score += 1;
            Debug.Log("Score: " + Player.score);
        }
    }
}
