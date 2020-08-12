using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour
{
    public void reload()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
    public void quit()
    {
        SceneManager.LoadScene(1);
    }
}
