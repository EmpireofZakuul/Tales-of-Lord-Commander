using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUp : MonoBehaviour
{
    public Timer Timer;
    public Counter counter;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {

            Timer.cdRemainingTime += 30;
            counter.counter ++;
            Destroy(gameObject);
            
        }
    }
}
