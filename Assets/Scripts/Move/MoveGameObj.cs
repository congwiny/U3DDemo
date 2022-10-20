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
        //以自己轴向往某个方向移动
        tfs[0].Translate(Vector3.right * speed * Time.deltaTime);
        //以自己轴向往x,y,z轴移动
        tfs[1].Translate(speed * Time.deltaTime, 0, 0);

        //沿世界坐标轴移动
        //tfs[2].Translate(Vector3.right * speed * Time.deltaTime, Space.World);
        tfs[2].Translate(speed * Time.deltaTime, 0, 0, Space.World);
        //沿其他游戏对象的轴线移动
        tfs[3].Translate(Vector3.right * speed * Time.deltaTime, tfRelative);
    }
}
