using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void reloadgame()
    {
        SceneManager.LoadScene(2);
    }
    public void quit()
    {
        Application.Quit();
    }

    public void objective()
    {
        SceneManager.LoadScene(3);
    }
}
