using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float hitPoints = 100f;
    [SerializeField] public GameObject player;


    private void Start()
    {
        
    }

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        if (hitPoints <= 0 || player.transform.position.y <= 40)
        {
            GetComponent<DeathHandler>().HandleDeath();
            Debug.Log("Dead!");
        }
    }
}
