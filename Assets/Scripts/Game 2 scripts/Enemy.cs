using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   // public int health = 1;
     public int playerMaxHealth = 3;
    public int playerCurrentHealth;
    public PlayerHealthBar healthBar;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
         playerCurrentHealth = playerMaxHealth;
        healthBar.PlayerMaxHealth(playerMaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerCurrentHealth <= 0)
        {
            Die();
        }
        if(gameObject.tag == "King" && playerCurrentHealth <=0){
            //Debug.Log("won");
            gameOver.SetActive(true);
        }


    }
    public void TakeDamage(int damage)
    {
       // health -= damage;
        playerCurrentHealth -= damage;
        healthBar.SetPlayerHealth(playerCurrentHealth);
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
