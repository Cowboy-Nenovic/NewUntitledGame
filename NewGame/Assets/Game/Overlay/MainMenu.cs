using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Load Scene
  public void Play()
    {
        SceneManager.LoadSceneAsync(1);
    }

    //Quit Game 
  public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    }
}
