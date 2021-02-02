using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Game");
    }

    public void GoHome(){
        SceneManager.LoadScene("MenuScene");
    }

    public void QuitGame(){
        Application.Quit();
    }
}
