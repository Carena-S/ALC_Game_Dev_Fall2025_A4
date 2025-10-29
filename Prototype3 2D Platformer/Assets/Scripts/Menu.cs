using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Add the Scene Management Namespace

public class Menu : MonoBehaviour
{

    public void OnPlayButton()
    {
        SceneManager.LoadScene(1); // Load Scene
    }

    public void OnQuitButton()
    {
        Application.Quit(); // Quit Game
    }
}
