﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundNoice : MonoBehaviour
{
    public static AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
