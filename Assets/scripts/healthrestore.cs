using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthrestore : MonoBehaviour
{
    [SerializeField] float meds = 20f;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            FindObjectOfType<playerhealth>().healthrestore(meds);
            Destroy(gameObject);
        }
    }
}
