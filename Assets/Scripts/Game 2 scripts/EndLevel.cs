using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public Sprite end;
    public GameObject towerClosed;
    public GameObject toweropen;
    // Start is called before the first frame update
    public PickupPlayer player;
    public bool changed = true;
    void Start()
    {
        towerClosed.SetActive(true);
        toweropen.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(player.pickedUp == 1&& changed)
        {
            changed = false;
            //tower.gameObject.GetComponent<SpriteRenderer>().sprite = end;
            towerClosed.SetActive(false);
            toweropen.SetActive(true);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("MapScene");
        }
    }
}
