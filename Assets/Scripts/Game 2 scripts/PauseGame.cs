using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    [Header("Pause Section")]
    public static bool gameIsPaused;
    public GameObject pauseButton;
    public GameObject pauseMenu;

    [Header("Music Section")]
    private Sprite soundOn;
    public Sprite soundOff;
    public Button button;
    public bool isOn = true;
    public AudioSource musicAudioSource;

   /* [Header("Sound Effects Section")]
    private Sprite soundEffectOn;
    public Sprite soundEffectOff;
    public Button soundEffectButton;
    public bool effectIsOn = true;
    public AudioSource[] soundEffectAudioSource;

    */
    void Start()
    {
        soundOn = button.image.sprite;
        pauseButton.SetActive(true);
        musicAudioSource.GetComponent<AudioSource>();
        musicAudioSource.Play();

        
       // soundEffectOn = soundEffectButton.image.sprite;
       // soundEffectAudioSource = GameObject.FindGameObjectsWithTag("SoundEffect");
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

    /*public void SoundEffectToggle()
    {
        if(effectIsOn)
        {
          soundEffectButton.image.sprite = soundEffectOff;
          isOn = false;
           
          foreach(AudioSource audioSource in soundEffectAudioSource)
          {
                 audioSource.Pause();
          }
        }
          
        else
        {
          soundEffectButton.image.sprite = soundEffectOn;
          isOn = true;    
        }
    }
    */

    
}
