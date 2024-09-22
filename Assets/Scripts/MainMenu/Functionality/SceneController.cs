using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadNextScene(string sceneName)
    {
       
        SceneManager.LoadScene(sceneName);
        
    }
    public void LoadMainMenu()
    {
        Destroy(GameObject.Find("Dialogue Manager"));
        SceneManager.LoadScene("MainMenu");
        
    }
}
