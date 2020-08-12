using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammopickups : MonoBehaviour
{
    [SerializeField] int ammoamount;
    [SerializeField] ammotype ammotype;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            Destroy(gameObject);
            FindObjectOfType<ammo>().ammoupdate(ammoamount, ammotype);
        }
    }
}
