using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //初速を入力値ロして準備
    public float speed = 200;
    Rigidbody rb;
    Transform myTransform;
    private void Start()
    {
        // rigidbodyを取得
        rb = this.GetComponent<Rigidbody>();
        // 力を設定
        Vector3 force = new Vector3(10.0f, -10.0f, 0.0f) * speed;
        // 力を加える
        //rb.AddForce(force);

         myTransform = transform;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bar"))
        {
            Vector3 barPos = collision.transform.position;
            Vector3 ballPos = myTransform.position;
            Vector3 direction = (ballPos - barPos).normalized;

            float speed = rb.velocity.magnitude;
           rb.velocity = direction * speed;
        }
    }
}