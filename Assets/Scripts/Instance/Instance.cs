using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance : MonoBehaviour
{
    public GameObject obj;

    public void InstanceGameObj()
    {
        Instantiate(obj);
    }
}
