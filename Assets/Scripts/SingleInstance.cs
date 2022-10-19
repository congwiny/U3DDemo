using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleInstance : MonoBehaviour
{
    private static SingleInstance instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (this != instance)
        {
            Destroy(gameObject);
            return;
        }
    }
}
