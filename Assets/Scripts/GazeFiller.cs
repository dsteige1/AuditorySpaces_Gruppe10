﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeFiller : MonoBehaviour
{
    public Image imgGaze;
    public float totalTime = 2;
    public bool gvrStatus;
    float gvrTimer;

    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
            //Debug.Log(imgGaze.fillAmount);
        }
        
    }

    public void GVRon()
    {
        gvrStatus   = true;
    }

    public void GVRoff()
    {
        gvrStatus   = false;
        gvrTimer    = 0;
        imgGaze.fillAmount = 0;
    }
}
