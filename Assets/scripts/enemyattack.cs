using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattack : MonoBehaviour
{
     playerhealth playertarget;
    [SerializeField] float playerdamage = 10f;
    void Start()
    {
        playertarget = FindObjectOfType<playerhealth>();
    }
    public void attack()
    {
        if (playertarget == null) return;
        playertarget.damage(playerdamage);
        playertarget.GetComponent<bloodsplatter>().showimpact();
    }
}
