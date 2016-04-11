using UnityEngine;
using System.Collections;

public class obmover1 : MonoBehaviour
{

    void Awake()
    {
    }

    void FixedUpdate()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "product")
        {
            other.transform.localScale = new Vector3(5, 2, 5);

        }
    }
}