using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battery : MonoBehaviour
{
    [SerializeField] float restorerange = 80f;
    [SerializeField] float restorelight = 1f;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            Destroy(gameObject);
            FindObjectOfType<flashlightsystem>().restorerange(restorerange);
            FindObjectOfType<flashlightsystem>().restoreintensity(restorelight);
        }
    }
}
