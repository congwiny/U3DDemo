using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start ->"+Time.time);
        StartCoroutine("testCoroutine");
        Debug.Log("end ->" + Time.time);
    }

    IEnumerator testCoroutine() 
    {
        Debug.Log("start coroutine ->" + Time.time);
        yield return new WaitForSeconds(1);
        Debug.Log("end coroutine ->" + Time.time);

    }
}
