using UnityEngine;
using System.Collections;

public class obmover7 : MonoBehaviour
{

    void Awake()
    {
    }

    void FixedUpdate()
    {
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" || other.tag == "product" || other.tag == "fish")
        {
            Rigidbody rbp = other.GetComponent<Rigidbody>();
            rbp.velocity = rbp.velocity * 0.8f;
            rbp.angularVelocity = rbp.angularVelocity * 0.8f;

            

        }
    }
}
