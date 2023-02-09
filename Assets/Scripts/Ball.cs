using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //��������͒l�����ď���
    public float speed = 200;
    Rigidbody rb;
    Transform myTransform;
    private void Start()
    {
        // rigidbody���擾
        rb = this.GetComponent<Rigidbody>();
        // �͂�ݒ�
        Vector3 force = new Vector3(10.0f, -10.0f, 0.0f) * speed;
        // �͂�������
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