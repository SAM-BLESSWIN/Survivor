using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class survivalpickups : MonoBehaviour
{
    [SerializeField] int currentpickup=0;
    public void picks()
    {
        if (currentpickup >= transform.childCount-1)
        {
            currentpickup = 0;
        }
        else
        {
            currentpickup++;
        }
        Debug.Log(currentpickup);
        pickupcycle();
    }

    private void pickupcycle()
    {
        int selectedpick = 0;
        foreach (Transform picks in transform)
        {
            if (selectedpick == currentpickup)
            {
                picks.gameObject.SetActive(true);
            }
            else
            {
                picks.gameObject.SetActive(false);
            }
            selectedpick++;
        }
    }
}
