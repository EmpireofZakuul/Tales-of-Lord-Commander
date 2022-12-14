using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
   /* //player health bar
    public int playerMaxHealth = 3;
    public int playerCurrentHealth;
    public PlayerHealthBar healthBar;

    */
    //player hearts
    [Header("Health")]
    public int playerHealth;
    public int playerNumberOfHearts;
    public Image[] playerHearts;
    public Sprite playerFullHeart;
    public Sprite playerEmptyHeart;
    public bool dead = false;

    public void Start()//all code related to player health bar
    {
        dead = false;
        //playerCurrentHealth = playerMaxHealth;
        //healthBar.PlayerMaxHealth(playerMaxHealth);
    }
    private void Update()//all code in update related to player hearts
    {
        if(playerHealth > playerNumberOfHearts)
        {
            playerHealth = playerNumberOfHearts;
        }


        for (int i = 0; i < playerHearts.Length; i++)
        {
            if(i < playerHealth)
            {
                playerHearts[i].sprite = playerFullHeart;
            }
            else
            {
                playerHearts[i].sprite = playerEmptyHeart;
            }
            if(i < playerNumberOfHearts)
            {
                playerHearts[i].enabled = true;
            }
            else
            {
                playerHearts[i].enabled = false;
            }
        } 

        if(playerHealth <=0 && !dead){
            Die();
        }
    }
    
    public void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.tag == "Enemy")
        {
            //playerCurrentHealth--;//player healthbar
            playerHealth--;//player hearts
            //healthBar.SetPlayerHealth(playerCurrentHealth);
        }


        if (Collision.gameObject.tag == "King")
        {
            //playerCurrentHealth--;//player healthbar
            playerHealth-= 3;//player hearts
            //healthBar.SetPlayerHealth(playerCurrentHealth);
        }

    }
    public void Die()
    {
        dead = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DeathZone")
        {
            
            playerCurrentHealth-=3;//player healthbar
            playerHealth-=3;//player hearts
            healthBar.SetPlayerHealth(playerCurrentHealth);
            
        }
    }
    */

}

