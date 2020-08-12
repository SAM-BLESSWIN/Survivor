using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponswitcher : MonoBehaviour
{

    [SerializeField] int currentweapon = 0;
    int previousweapon;
    void Start()
    {
        weaponcycle();
    }
    public void Update()
    {
        previousweapon = currentweapon;
        processkeyinput();
        processscrollwheel();
        if(previousweapon!=currentweapon)
        {
            weaponcycle();
        }
    }

    private void processscrollwheel()
    {
        if(Input.GetAxis("Mouse ScrollWheel")<0)
        {
            if(currentweapon>=transform.childCount-1)
            {
                currentweapon = 0;
            }
            else
            {
                currentweapon++;
            }
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (currentweapon <=0)
            {
                currentweapon = transform.childCount - 1;
            }
            else
            {
                currentweapon--;
            }
        }
    }

    private void processkeyinput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentweapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentweapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentweapon = 2;
        }
    }

    private void weaponcycle()
    {
        int selectedweapon = 0;
        foreach (Transform weapon in transform)
        {
            if(selectedweapon==currentweapon)
            {
                weapon.gameObject.SetActive(true); 
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            selectedweapon++;
        }
    }
}
