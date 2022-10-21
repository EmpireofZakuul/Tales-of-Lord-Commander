using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public string[] sentances;
    public TextMeshProUGUI dialogText;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject Panel;
    //public bool activeConversation = false;
    // Start is called before the first frame update
    void Start()
    {
      dialogText.text = "";
        //Panel.SetActive(true);
        //StartCoroutine(Type());
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogText.text == sentances[index]){
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
         foreach(char letter in sentances[index].ToCharArray())
         {
             dialogText.text += letter;
             yield return new WaitForSeconds(typingSpeed);
         }
    }

    public void ContinueSentance(){
         continueButton.SetActive(false);
        if(index < sentances.Length - 1){
            index++;
            dialogText.text = "";
            StartCoroutine(Type());

        }
        else{
            dialogText.text = "";
             continueButton.SetActive(false);
            Panel.SetActive(false);
            //activeConversation = false;
        }
    }

   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Conversation" &&!activeConversation)
        {
            
            activeConversation = true;
        }
        
    }
    */

    public void StartConversation()
    {
        Panel.SetActive(true);
        StartCoroutine(Type());
    }


}
