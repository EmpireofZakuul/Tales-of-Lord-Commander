using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public static bool gameIsPaused;
    public GameObject pauseButton;
    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        
        pauseButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

   public void GamePaused()
    {      
         pauseButton.SetActive(false);   
         pauseMenu.SetActive(true);
         Time.timeScale = 0f;
           
       
    }
   public void PlayGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
    }

    public void ReturnToMap()
    {
       SceneManager.LoadScene("Map");
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
