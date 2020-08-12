using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class petrolcount : MonoBehaviour
{
    carescape carescape;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            carescape.FindObjectOfType<carescape>().petrolcount();
            Destroy(gameObject);
        }
    }
}
