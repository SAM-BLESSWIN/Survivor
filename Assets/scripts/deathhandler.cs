using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityStandardAssets.Characters.FirstPerson;

public class deathhandler : MonoBehaviour
{
    FirstPersonController fpc;
    [SerializeField] Canvas gameoverscene;
    public void Start()
    {
        fpc = GetComponent<FirstPersonController>();
        gameoverscene.enabled = false;
    }
    public void deathscene()
    {
        gameoverscene.enabled = true;
        FindObjectOfType<weaponswitcher>().enabled = false;
        Time.timeScale = 0;
        fpc.m_MouseLook.lockCursor = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
