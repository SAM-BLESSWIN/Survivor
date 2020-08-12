using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carescape : MonoBehaviour
{
    [SerializeField] int petrolcancount=0;
    [SerializeField] TextMeshProUGUI petroltxt;
    public void Update()
    {
        petroltxt.text = petrolcancount.ToString();
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player" && petrolcancount==5)
        {
            StartCoroutine(WaitForSceneLoad());
            
        }
    }
    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(4);

    }
    public void petrolcount()
    {
        petrolcancount++;
    }
}
