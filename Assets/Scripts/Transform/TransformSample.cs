using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformSample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //���õ���ȫ������
       // transform.position = new Vector3 (1.5f,1,0);
        //���õ��Ǿֲ�����
        transform.localPosition = new Vector3(1.5f, 1, 0);
    }

}
