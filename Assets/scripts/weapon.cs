using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
//using UnityEditor.Experimental.UIElements;
using UnityEngine;
using UnityEngine.Serialization;

public class weapon : MonoBehaviour
{
    [SerializeField] ammo bullets;
    [SerializeField] ammotype ammotype;
    [SerializeField] Camera fpcam;
    [SerializeField] float firerange = 100f;
    [SerializeField] float damage = 1f;
    [SerializeField] ParticleSystem muzzleflash;
    [SerializeField] GameObject hiteffect;
    [SerializeField] float timedelay= 0.5f;
    [SerializeField] TextMeshProUGUI ammotext;
    [SerializeField] AudioSource weaponfire;

    bool isshoot = true;
    public void OnEnable()
    {
        isshoot = true;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && isshoot==true)
        {
            int ammocount = bullets.getcurrentammo(ammotype);
            if(ammocount>0)
            {
               StartCoroutine(shoot());
                bullets.ammunation(ammotype);
            }
        }
        ammodisplay();
    }

    private void ammodisplay()
    {
        int ammocount = bullets.getcurrentammo(ammotype);
        ammotext.text = ammocount.ToString();
    }

    IEnumerator shoot()
    {
        isshoot = false;
        processraycast();
        muzzleflair();
        weaponfire.Play();
        yield return new WaitForSeconds(timedelay);
        isshoot = true;
    }

    private void muzzleflair()
    {
        muzzleflash.Play();
    }

    private void processraycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpcam.transform.position, fpcam.transform.forward, out hit, firerange))
        {
            
            createhitimpact(hit);
            enemyhealth enemytarget = hit.transform.GetComponent<enemyhealth>();
            if (enemytarget == null) return;   //just return when enemy is detroyed or enemy is not present
            enemytarget.takedamage(damage);
        }
        else
        {
            return;
        }
    }

    private void createhitimpact(RaycastHit hit)
    {
        var impact=Instantiate(hiteffect, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impact,0.1f);
    }
}
