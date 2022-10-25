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
  
    
    void Start()
    {
      dialogText.text = "";
        
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

    public void ContinueSentance()
    {
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
          
        }
    }

    public void StartConversation()
    {
        Panel.SetActive(true);
        StartCoroutine(Type());
    }
    


}
