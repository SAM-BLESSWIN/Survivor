using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloodsplatter : MonoBehaviour
{
    [SerializeField] Canvas impactcanvas;
    [SerializeField] float disptime = 0.3f; 
    void Start()
    {
        impactcanvas.enabled = false;
    }
    
    public void showimpact()
    {
        StartCoroutine("showsplatter");
    }

    IEnumerator showsplatter()
    {
        impactcanvas.enabled = true;
        yield return new WaitForSeconds(disptime);
        impactcanvas.enabled = false;
    }
}
