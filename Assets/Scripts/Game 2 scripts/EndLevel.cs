using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public Sprite end;
    public GameObject tower;
    // Start is called before the first frame update
    public PickupPlayer player;
    public bool changed = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.pickedUp == 1&& changed)
        {
            changed = false;
            tower.gameObject.GetComponent<SpriteRenderer>().sprite = end;
        }
    }
}
