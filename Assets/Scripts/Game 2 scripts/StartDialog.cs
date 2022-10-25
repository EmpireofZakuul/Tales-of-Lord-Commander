using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDialog : MonoBehaviour
{
    public Dialog playerconversation;
    public bool activeConversation;
   
   
    // Start is called before the first frame update
    void Start()
    {

    
        activeConversation = false;
        
    }

   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if ( !activeConversation  && collision.gameObject.tag == "Conversation" )
        {          
            activeConversation = true;
            playerconversation.StartConversation();
           
        }
        
    }
}
