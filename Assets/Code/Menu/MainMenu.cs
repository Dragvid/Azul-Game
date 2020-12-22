using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public string sceneGame;
    public string sceneMainMenu;
    public string sceneTutorial;
    public string sceneLeaderboard;
    public string sceneRooms;
    //public string[] levels;
    /*public void StartLevel()
    {
        int levelNumber = Random.Range(0, levels.Length);
        SceneManager.LoadScene(levels[levelNumber]);

    }*/
    public void Quit()
    {
        Application.Quit();
    }
    public void Tutorial()
    {
        SceneManager.LoadScene(sceneTutorial);
    }
    public void Rooms()
    {
        SceneManager.LoadScene(sceneRooms);
    }
    public void Leaderboard()
    {
        SceneManager.LoadScene(sceneLeaderboard);
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(sceneMainMenu);
    }
}
