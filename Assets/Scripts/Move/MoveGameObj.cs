using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGameObj : MonoBehaviour
{
    public Transform[] tfs;
    public float speed;
    public Transform tfRelative;


    // Update is called once per frame
    void Update()
    {
        //���Լ�������ĳ�������ƶ�
        tfs[0].Translate(Vector3.right * speed * Time.deltaTime);
        //���Լ�������x,y,z���ƶ�
        tfs[1].Translate(speed * Time.deltaTime, 0, 0);

        //�������������ƶ�
        //tfs[2].Translate(Vector3.right * speed * Time.deltaTime, Space.World);
        tfs[2].Translate(speed * Time.deltaTime, 0, 0, Space.World);
        //��������Ϸ����������ƶ�
        tfs[3].Translate(Vector3.right * speed * Time.deltaTime, tfRelative);
    }
}
