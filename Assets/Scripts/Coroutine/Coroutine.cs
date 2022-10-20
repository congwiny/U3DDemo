using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start ->" + Time.time);
        //StartCoroutine("testCoroutine");
        //延迟2s调用testInvoke方法
        //Invoke("testInvoke", 2);
        InvokeRepeating("testRepeatInvoke", 1, 3);
        Debug.Log("end ->" + Time.time);
    }

    IEnumerator testCoroutine()
    {
        Debug.Log("start coroutine ->" + Time.time);
        yield return new WaitForSeconds(1);
        Debug.Log("end coroutine ->" + Time.time);

    }

    void testInvoke()
    {
        Debug.Log("test Invoke ->" + Time.time);
    }

    void testRepeatInvoke()
    {
        Debug.Log("test Invoke ->" + Time.time);
    }
}
