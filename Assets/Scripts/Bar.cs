using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    void Update()
    {
        //Bar�̍��W�����܂��B
        Transform BarTrans = GameObject.Find("Bar").transform;
        Vector3 pos = BarTrans.position;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Bar�̍��W��20�ȉ��i�ǂ������j�ł���ꍇ�ɂ͈ړ������{���܂��B
            if (pos.x < 20)
�@�@�@�@�@�@{
                this.transform.Translate(0.5f, 0f, 0f);
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Bar�̍��W��-20�ȏ�i�ǂ������j�ł���ꍇ�ɂ͈ړ������{���܂��B
            if (pos.x > -20)
�@�@�@�@�@�@{
                this.transform.Translate(-0.5f, 0f, 0f);
            }
        }
    }
}