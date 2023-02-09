using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockControl : MonoBehaviour
{
    public Transform blockPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //配置する座標を設定
        Vector3 placePosition = new Vector3(-20, 20, 0);
        //配置する回転角を設定
        Quaternion q = new Quaternion();
        q = Quaternion.identity;
        //配置
        for(int i = 0; i < 5; i++)
        {
            Instantiate(blockPrefab, placePosition, q);
            //x座標を変更し配置
            placePosition.x += 10;
            
        }
        
    }
}
