using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

    public void LevelMenu()
    {
        SceneManager.LoadScene("LevelMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
