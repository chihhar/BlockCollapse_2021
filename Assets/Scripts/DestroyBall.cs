using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;

public class DestroyBall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(collision.gameObject);
        //EndEpisode();
        //Debug.Log("Destroy ball");
    }
}
