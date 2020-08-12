using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityStandardAssets.Characters.FirstPerson;

public class camerazoom : MonoBehaviour
{
    bool istogglezoom = false;
    [SerializeField] Camera fovcam;
    [SerializeField] FirstPersonController fpc;
    [SerializeField] float zoomoutFOV =60f;
    [SerializeField] float zoominFOV =25f;
    [SerializeField] float zoomoutsenstivity =2f;
    [SerializeField] float zoominsenstivity =0.5f;

    public void OnDisable()
    {
        zoomout();
    }
    public void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(istogglezoom==false)
            {
                zoomin();
            }
            else
            {
                zoomout();
            }
        }
    }

    private void zoomin()
    {
        istogglezoom = true;
        fovcam.fieldOfView = zoominFOV;
        fpc.m_MouseLook.XSensitivity = zoominsenstivity;
        fpc.m_MouseLook.YSensitivity = zoominsenstivity;
    }

    private void zoomout()
    {
        istogglezoom = false;
        fovcam.fieldOfView = zoomoutFOV;
        fpc.m_MouseLook.XSensitivity = zoomoutsenstivity;
        fpc.m_MouseLook.YSensitivity = zoomoutsenstivity;
    }
}
