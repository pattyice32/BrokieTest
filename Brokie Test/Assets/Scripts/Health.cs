using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 100;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] TextMeshProUGUI healthText;


    public void TakeDamage(float damage)
    {
        health -= damage;
    }

    private void Update()
    {
        healthText.text = health.ToString();
        if(health <= 0)
        {
            Respawn();
            health = 100;
        }
    }

    private void Respawn()
    {
        transform.position = respawnPoint.position;
    }
}
