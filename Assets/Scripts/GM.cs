using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public static bool Play = true;
    public GameObject RestartPanel;

    void Update() 
    {
        if (!Play) 
        {
            RestartPanel.SetActive(true);
        }
    }
}
