using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockControl : MonoBehaviour
{
    public Transform blockPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //�z�u������W��ݒ�
        Vector3 placePosition = new Vector3(-20, 20, 0);
        //�z�u�����]�p��ݒ�
        Quaternion q = new Quaternion();
        q = Quaternion.identity;
        //�z�u
        for(int i = 0; i < 5; i++)
        {
            Instantiate(blockPrefab, placePosition, q);
            //x���W��ύX���z�u
            placePosition.x += 10;
            
        }
        
    }
}
