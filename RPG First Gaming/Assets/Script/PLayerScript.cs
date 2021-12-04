using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PLayerScript : Entity
{
    // Public Variables
    public float playerSpeed;
    public float playerTrunSpeed;
    public int playerMaxHealth;
    public int damageGivenToEnemy;


    // Functions
    // Start is called before the first frame update
    void Start()
    {
        InitializedEntity(playerMaxHealth, damageGivenToEnemy);
        //playerRb = GetComponent<Rigidbody>();
        
    }
    // Update is called once per frame
    void Update()
    {

        PlayerMovement(playerSpeed, playerTrunSpeed);

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            EnemyScript enemy = other.gameObject.GetComponent<EnemyScript>();
            InstantiateFight(enemy);
        }
    }

    private void InstantiateFight(EnemyScript enemy)
    {
        Attack(enemy);
    }
}
