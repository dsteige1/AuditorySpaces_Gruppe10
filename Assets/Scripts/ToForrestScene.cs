﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToForrestScene : MonoBehaviour
{

    public AudioSource TriggerSource;

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "SpaceStudio")
        {
            if (TriggerSource.reverbZoneMix >= 1.05 && TriggerSource.volume >= 0.9)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

        }
        else if (SceneManager.GetActiveScene().name == "SpaceStudio_II")
        {
            if (TriggerSource.volume >= 0.9)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
