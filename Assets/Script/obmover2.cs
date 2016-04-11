using UnityEngine;
using System.Collections;

public class obmover2 : MonoBehaviour
{
    private bool col;

    void Awake()
    {
    }

    void FixedUpdate()
    {
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Player")
        {
            col = true;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" || other.tag == "product")
        {
            Rigidbody rbp = other.GetComponent<Rigidbody>();
            Vector3 hehe = transform.position - other.transform.position;
            hehe = hehe.normalized;
            Vector3 hehe2 = hehe * 0.9f;
            if (col == true)
            {
                rbp.velocity = new Vector3(0, 0, 0);
                rbp.angularVelocity = new Vector3(0, 0, 0);
                rbp.Sleep();
                rbp.AddForce(hehe2, ForceMode.Acceleration);
            }

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "product")
        {
            Rigidbody rbp = other.GetComponent<Rigidbody>();
            Vector3 hehe = transform.position - other.transform.position;
            hehe = hehe.normalized;
            Vector3 hehe1 = hehe * 150f;
            rbp.AddForce(hehe1, ForceMode.Impulse);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            col = false;
        }
        if (other.tag == "product")
        {
            Rigidbody rbp1 = other.GetComponent<Rigidbody>();
            rbp1.velocity = new Vector3(0, 0, 0);
            rbp1.angularVelocity = new Vector3(0, 0, 0);
            rbp1.Sleep();
        }
    }
}