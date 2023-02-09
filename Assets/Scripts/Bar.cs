using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    void Update()
    {
        //Barの座標を取ります。
        Transform BarTrans = GameObject.Find("Bar").transform;
        Vector3 pos = BarTrans.position;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Barの座標が20以下（壁より内側）である場合には移動を実施します。
            if (pos.x < 20)
　　　　　　{
                this.transform.Translate(0.5f, 0f, 0f);
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Barの座標が-20以上（壁より内側）である場合には移動を実施します。
            if (pos.x > -20)
　　　　　　{
                this.transform.Translate(-0.5f, 0f, 0f);
            }
        }
    }
}