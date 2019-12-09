using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Loads the next scene in the game
    public void Playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //allow the user to exit the game
    public void Exitgame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
