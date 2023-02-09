using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<Score>().AddPoint(10);
        //Destroy(gameObject);
        gameObject.SetActive(false);
    }
}
