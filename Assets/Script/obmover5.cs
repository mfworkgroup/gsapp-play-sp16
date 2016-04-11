using UnityEngine;
using System.Collections;

public class obmover5 : MonoBehaviour
{

    void Awake()
    {
    }

    void FixedUpdate()
    {
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Rigidbody rbp = other.GetComponent<Rigidbody>();
            Vector3 hehe = transform.forward;
            Vector3 hehe1 = Quaternion.Euler(0, 0.1f, 0) * hehe;
            Vector3 hehe2 = hehe1.normalized;
            Vector3 hehe3 = hehe2 * 10;
            rbp.AddForce(hehe3, ForceMode.Acceleration);
            rbp.useGravity = true;
        }
        if (other.tag == "product")
        {
            Rigidbody rbp = other.GetComponent<Rigidbody>();
            rbp.useGravity = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" || other.tag == "product")
        {
            Rigidbody rbp1 = other.GetComponent<Rigidbody>();
            rbp1.useGravity = false;

        }
    }
}