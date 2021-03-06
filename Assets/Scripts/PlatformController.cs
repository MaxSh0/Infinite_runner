﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public GameObject[] Platforms;
    public GameObject[] prefabPlatforms;

    void Update()
    {



        for (int i = 0; i < Platforms.Length; i++)
        {
            if (Platforms[i] == null)
            {
                Debug.Log("Object is invisible");
                if (i != 0)
                {
                    Platforms[i] = Instantiate(prefabPlatforms[Random.Range(0, 5)], new Vector3(0, 0, Platforms[i-1].transform.position.z + 9), Quaternion.identity);
                }
                else
                {
                    Platforms[i] = Instantiate(prefabPlatforms[Random.Range(0, 5)], new Vector3(0, 0, Platforms[4].transform.position.z + 9), Quaternion.identity);
                }
            }
        }
    }


}
