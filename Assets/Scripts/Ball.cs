using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //‰‘¬‚ğ“ü—Í’lƒ‚µ‚Ä€”õ
    public float speed = 200;
    Rigidbody rb;
    Transform myTransform;
    private void Start()
    {
        // rigidbody‚ğæ“¾
        rb = this.GetComponent<Rigidbody>();
        // —Í‚ğİ’è
        Vector3 force = new Vector3(10.0f, -10.0f, 0.0f) * speed;
        // —Í‚ğ‰Á‚¦‚é
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