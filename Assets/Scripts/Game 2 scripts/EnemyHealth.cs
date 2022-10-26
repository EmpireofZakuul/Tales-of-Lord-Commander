using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    //player health bar
    public int playerMaxHealth = 3;
    public int playerCurrentHealth;
    public PlayerHealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
        healthBar.PlayerMaxHealth(playerMaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        playerCurrentHealth -= damage;
        healthBar.SetPlayerHealth(playerCurrentHealth);
    }
     
    
}
