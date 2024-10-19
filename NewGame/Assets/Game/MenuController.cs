using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//In MenuController wichtig die Level name ändern bei der Richtigen Level die in spiel sein soll!!

public class MenuController : MonoBehaviour
{
    [Header("Levels To Load")]
    public string _StartGameLevel;
    private string levelToLoad;
    [SerializeField] private GameObject noSavedGameDialog = null;

    public void StartGameDialogYes()
    {
        SceneManager.LoadScene(_StartGameLevel);
    }

    public void LoadGameDialogYes()
    {
        if (PlayerPrefs.HasKey("SavedLevel"))
        {
            levelToLoad = PlayerPrefs.GetString("SavedLevel");
            SceneManager.LoadScene(levelToLoad);
        }
        else
        {
            noSavedGameDialog.SetActive(true);
        }
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
