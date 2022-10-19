using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformSample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //设置的是全局坐标
       // transform.position = new Vector3 (1.5f,1,0);
        //设置的是局部坐标
        transform.localPosition = new Vector3(1.5f, 1, 0);
    }

}
