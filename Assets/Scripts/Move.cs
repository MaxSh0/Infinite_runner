﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    void Update()
    {
        transform.Translate(new Vector3(0, 0, -5f) * Time.deltaTime);
        //для тестов
        if (transform.position.z <= -8)
        {
            Destroy(gameObject);
        }


    }

    /*void OnBecameInvisible()
    {
        Destroy(gameObject);
    }*/
}
