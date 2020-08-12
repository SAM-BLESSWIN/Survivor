using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class logointro : MonoBehaviour
{
    public float waittime = 15f;
    void Start()
    {
        StartCoroutine("intrologo");
    }

    IEnumerator intrologo()
    {
        yield return new WaitForSeconds(waittime);
        SceneManager.LoadScene(1);
    }

}
