using UnityEngine;
using System.Collections;

public class obmover6 : MonoBehaviour
{

    void Awake()
    {
    }

    void FixedUpdate()
    {
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" || other.tag == "product")
        {
            Rigidbody rbp = other.GetComponent<Rigidbody>();
            Vector3 hehe = rbp.transform.position - transform.position;
            Vector3 hehe1 = hehe.normalized;
            Vector3 hehe2 = hehe1 * 40;
            rbp.AddForce(hehe2, ForceMode.Acceleration);

        }
    }
}
