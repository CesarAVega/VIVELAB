﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Cookie : MonoBehaviour {

    public Action touched;

    void OnTriggerEnter(Collider other) {
        gameObject.SetActive(false);
        if (touched != null) {
            touched();
        }
        
    }
}
