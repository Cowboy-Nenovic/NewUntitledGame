using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [Header("Levels To Load")]
    public string _StartGameLevel;
    private string levelToLoad;

    public void StartGameDialogYes()
    {
        SceneManager.LoadScene(_StartGameLevel);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
