using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Button startGame;
    //public Button playerControls;
    public Button quitGame;
   // public Button returnToMainMenu;
   public GameObject setting;

    public void Gamelevel()
    {
        SceneManager.LoadScene("Game 2");
    }

    public void Settings()
    {
        //SceneManager.LoadScene("Controls");
        setting.SetActive(true);
    }
    public void ReturnToMainMenu()
    {
        //SceneManager.LoadScene("Main Menu");
         setting.SetActive(false);
    }

    public void QuitTheGame()
    {

        #if UNITY_STANDALONE
        Application.Quit();
        #endif

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }


    
   
   
}
