using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public GameObject[] Platforms;
    public GameObject[] prefabPlatforms;

    void Update()
    {

        if(Platforms[0] == null)
        {
            Debug.Log("Object is invisible");
            Platforms[0] = Instantiate(prefabPlatforms[Random.Range(0, 5)], new Vector3(0, 0, 41), Quaternion.identity);
        }
        else if (Platforms[1] == null)
        {
            Debug.Log("Object is invisible");
            Platforms[1] = Instantiate(prefabPlatforms[Random.Range(0, 5)], new Vector3(0, 0, 41), Quaternion.identity);
        }
        else if (Platforms[2] == null)
        {
            Debug.Log("Object is invisible");
            Platforms[2] = Instantiate(prefabPlatforms[Random.Range(0, 5)], new Vector3(0, 0, 41), Quaternion.identity);
        }
        else if (Platforms[3] == null)
        {
            Debug.Log("Object is invisible");
            Platforms[3] = Instantiate(prefabPlatforms[Random.Range(0, 5)], new Vector3(0, 0, 41), Quaternion.identity);
        }
        else if (Platforms[4] == null)
        {
            Debug.Log("Object is invisible");
            Platforms[4] = Instantiate(prefabPlatforms[Random.Range(0, 5)], new Vector3(0, 0, 41), Quaternion.identity);
        }


    }


}
