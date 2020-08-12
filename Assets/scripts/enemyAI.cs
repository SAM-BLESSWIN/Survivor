using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;
using UnityEngine.AI;

public class enemyAI : MonoBehaviour
{
    
    [SerializeField] float chaserange = 5f;
    [SerializeField] float turnspeed=5f;

    NavMeshAgent navmesh;
    float dist = Mathf.Infinity;
    bool isprovoked = false;
    enemyhealth health;
    Transform target;
    void Start()
    {
        target = FindObjectOfType<playerhealth>().transform;
        navmesh = GetComponent<NavMeshAgent>();
        health = GetComponent<enemyhealth>();
    }
    void Update()
    {
        dist = Vector3.Distance(target.position, transform.position);

        if(health.Isdead())
        {
            enabled = false;    //disable Ai script
        }
        if (dist <= chaserange || isprovoked)
        {
            engagetarget();
        }
        else
        {
            idle();
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaserange);
    }
    public void damagetaken()
    {
        isprovoked = true;
        engagetarget();
    }

    private void idle()
    {
        GetComponent<Animator>().SetTrigger("idle");
    }
    private void engagetarget()
    {
        facetarget();
        if (dist>=navmesh.stoppingDistance)
        {
            chasetarget();
        }
        if (dist<navmesh.stoppingDistance)
        {
            attacktarget();
        }
    }
    private void chasetarget()
    {
        GetComponent<Animator>().SetTrigger("move");
        GetComponent<Animator>().SetBool("attack", false);
        navmesh.SetDestination(target.position);
    }
    private  void attacktarget()
    {
        GetComponent<Animator>().SetBool("attack", true);
    }

    private void facetarget()
    {
        Vector3 direction = (target.position-transform.position).normalized;
        Quaternion lookrotation = Quaternion.LookRotation(new Vector3(direction.x, 0f, direction.z));
        transform.rotation=Quaternion.Slerp(transform.rotation,lookrotation,Time.deltaTime*turnspeed);
    }
    
}
