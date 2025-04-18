﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldownTimer;

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && cooldownTimer < 0)
        {
            cooldownTimer = 1;

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
