using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PickupPlayer : MonoBehaviour
{
    public PlayerHealth playerHealth;
    //public GameObject heartEmpty;
     public GameObject heartFull;
     public float pickedUp = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pickedUp == 1)
        {
            //SceneManager.LoadScene("Game 3")

        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Armor")
        {
            playerHealth.playerHealth += 1;
            playerHealth.playerNumberOfHearts += 1;
            //heartEmpty.SetActive(true);
            heartFull.SetActive(true);
            pickedUp++;
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "EndLevel")
        {

        }
    }
}
