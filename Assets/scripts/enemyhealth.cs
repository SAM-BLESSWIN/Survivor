using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    
   [SerializeField] float hitpoints = 10f;
   [SerializeField] GameObject pickups;
    bool isdead = false;

    public bool Isdead() //stop chasing after dead (called from AI)
    {
        return isdead;
    }

    public void takedamage(float damage)
    {
        BroadcastMessage("damagetaken");
        hitpoints -= damage;
        kill();
    }

    private void kill()
    {
        if (hitpoints <= 0)
        {
            dead();
        }
    }

    public void dead()
    {
        if(isdead)  //stop animation from playing again
        {
            return;
        }
        isdead = true;
        GetComponent<Animator>().SetTrigger("dead");
        pickups.GetComponent<survivalpickups>().picks();
        StartCoroutine("waitforpickups");
    }


    IEnumerator waitforpickups()
    {
        yield return new WaitForSeconds(3);
        Instantiate(pickups,gameObject.transform.position, Quaternion.identity); 
     }
}

