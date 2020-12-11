using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMoney : MonoBehaviour
{

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(100, 0, 0)*Time.fixedDeltaTime);
    }
}
