using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
   [Header("Pause Section")]
    public GameObject pauseMenu;
    public static bool gameIsPaused;
    public GameObject pauseButton;
    public GameObject moveLeftButton;
    public GameObject moveRightButton;
    public GameObject attackButton;

    

    [Header("Music Section")]
    public bool isOn = true;
    private Sprite soundOn;
    public Sprite soundOff;
    public Button button;
    public AudioSource musicAudioSource;

    [Header("Sound Effects Section")]
    public bool effectIsOn = true;
    private Sprite soundEffectOn;
    public Sprite soundEffectOff;
    public Button soundEffectButton;
    public AudioSource[] soundEffectAudioSource;
    

    
    void Start()
    {
        soundOn = button.image.sprite;
        pauseButton.SetActive(true);
        musicAudioSource.GetComponent<AudioSource>();
        musicAudioSource.Play();

        
        soundEffectOn = soundEffectButton.image.sprite;
       // soundEffectAudioSource = GameObject.FindGameObjectsWithTag("SoundEffect");
        //soundEffectAudioSource

        //soundEffectAudioSource = FindObjectsOfType<AudioSource>();
      
    }


   public void GamePaused()
    {      
         pauseButton.SetActive(false);  
         moveLeftButton.SetActive(false);
         moveRightButton.SetActive(false);
         attackButton.SetActive(false);
         pauseMenu.SetActive(true);
         Time.timeScale = 0f;    
    }


   public void PlayGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
         moveLeftButton.SetActive(true);
         moveRightButton.SetActive(true);
         attackButton.SetActive(true);
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

 
    public void MusicToggle()
    {
      
      if(isOn){
          button.image.sprite = soundOff;
          isOn = false;
          musicAudioSource.Pause();

      }
      else
      {
          button.image.sprite = soundOn;
          isOn = true;         
           musicAudioSource.Play();
      }
    } 
  

    public void SoundEffectToggle()
    {
        if(effectIsOn)
        {
          soundEffectButton.image.sprite = soundEffectOff;
          effectIsOn = false;
           
          foreach(AudioSource audioSource in soundEffectAudioSource)
          {
                 audioSource.Pause();
          }
        }
          else 
        {
          soundEffectButton.image.sprite = soundEffectOn;
          effectIsOn = true;  
          
          foreach(AudioSource audioSource in soundEffectAudioSource)
          {
                 audioSource.Play();
          }
        }
        
        
    }    
}
