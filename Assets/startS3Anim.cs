﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startS3Anim : MonoBehaviour
{
    [SerializeField] GameObject tableFlame;
    [SerializeField] GameObject section3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            tableFlame.SetActive(true);
            section3.SetActive(true);

            
        }
    }
}