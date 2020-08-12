using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlightsystem : MonoBehaviour
{
    [SerializeField] float lightdecay = .1f;
    [SerializeField] float angledecay = 1f;
    [SerializeField] float minangle = 40f;

    Light flashlight;
    private void Start()
    {
        flashlight = GetComponent<Light>();
    }
    private void Update()
    {
        lightfade();
        rangefade();
    }

    private void rangefade()
    {
       if(flashlight.spotAngle<=minangle)
        {
            return;
        }
        else
        {
            flashlight.spotAngle -= angledecay * Time.deltaTime;
        }
    }

    private void lightfade()
    {
        flashlight.intensity -= lightdecay * Time.deltaTime;
    }

    public void restorerange(float restorerange)
    {
        flashlight.spotAngle = restorerange;
    }

    public void restoreintensity(float restorelight)
    {
        flashlight.intensity = restorelight;
    }
}
