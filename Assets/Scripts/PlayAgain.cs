using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    //Untuk Play Again
    public void playAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //untuk ke level 2
    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //untuk ke level 1
    public void prevScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void L1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void L2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void L3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void L4()
    {
        SceneManager.LoadScene("Level4");
    }
    public void L5()
    {
        SceneManager.LoadScene("Level5");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Home");
    }
}
