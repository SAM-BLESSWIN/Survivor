using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
 

    [SerializeField] ammoslot[] ammoslots;
    [System.Serializable]
    private class ammoslot   //class within a class
    {
        public ammotype ammotype;
        public int ammocount;
    }
    public void ammoupdate(int ammoammount,ammotype ammotype)
    {
        foreach(ammoslot slot in ammoslots)
        {
            if (slot.ammotype == ammotype)
            {
                slot.ammocount += ammoammount;
            }
        }
    }

    public int getcurrentammo(ammotype ammotype)
    {
        return getammoslot(ammotype).ammocount;
    }
    public void ammunation(ammotype ammotype)
    {
       getammoslot(ammotype).ammocount--;
    }

    private ammoslot getammoslot(ammotype ammotype)
    {
        foreach(ammoslot slot in ammoslots)
        {
            if(slot.ammotype==ammotype)
            {
                return slot;
            }
        }
        return null;
    }
}
