using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    //private variables For Entity 
    private int entityHealth;
    private int damageGiven;

    //public Variables For Entity
    public int currentHealth;
    public int damageMultiplies;

    public void InitializedEntity(int entityHealth, int damageGiven)
    {
        this.entityHealth = entityHealth;
        currentHealth = entityHealth;
        damageMultiplies = 1;
        this.damageGiven = damageGiven;
    }

   

    public void PlayerMovement(float playerSpeed, float playerTrunSpeed)
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // playerRb.AddRelativeForce(Vector3.forward * playerSpeed);
            transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //playerRb.AddRelativeForce(Vector3.back * playerSpeed);
            transform.Translate(Vector3.back * Time.deltaTime * playerSpeed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * playerTrunSpeed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * playerTrunSpeed);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetDamage(int damage)
    {
        entityHealth -= damage;
        if (entityHealth <= 0)
        {
            GameObject.Destroy(this.gameObject);
        }
    }

    public void Attack(Entity Enemy)
    {
        Enemy.GetAttack(damageGiven * damageMultiplies);
    }
    public virtual void GetAttack(int damage)
    {
        GetDamage(damage);
    }
}
