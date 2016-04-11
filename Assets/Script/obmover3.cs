using UnityEngine;
using System.Collections;

public class obmover3 : MonoBehaviour
{

    void Awake()
    {
    }

    void FixedUpdate()
    {
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "product")
        {
            Rigidbody rbp = other.GetComponent<Rigidbody>();
            Vector3 hehe = transform.forward * -1f;
            hehe = hehe.normalized;
            hehe = hehe * 2f;
            rbp.AddForce(hehe, ForceMode.Impulse);

        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Rigidbody rbp = other.GetComponent<Rigidbody>();
            Vector3 hehe = transform.forward * -1f;
            hehe = hehe.normalized;
            hehe = hehe * 300f;
            rbp.AddForce(hehe, ForceMode.Impulse);

        }
    }
}