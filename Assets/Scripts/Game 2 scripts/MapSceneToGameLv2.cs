using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSceneToGameLv2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveToGame());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MoveToGame()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Game 3");
    }
}
