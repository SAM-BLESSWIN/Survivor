using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerhealth : MonoBehaviour
{
    [SerializeField] float health = 70;
    [SerializeField] TextMeshProUGUI healthtext;

    public void Update()
    {
        healthtext.text = health.ToString();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(1);
        }
    }
    public void damage(float playerdamage)
    {
        health -= playerdamage;
        dead();
    }
    public void healthrestore(float healthrestore)
    {
        health += healthrestore;
    }

    private void dead()
    {
        if (health <= 0)
        {
            GetComponent<deathhandler>().deathscene();
        }
    }
}
