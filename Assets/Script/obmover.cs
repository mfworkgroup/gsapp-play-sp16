using UnityEngine;
using System.Collections;

public class obmover : MonoBehaviour
{
    public GameObject piano;
    public GameObject piano1;
    public GameObject piano2;
    public GameObject piano3;
    public GameObject piano4;
    public GameObject piano5;
    public int ab;

    void Awake()
    {
    }

    void FixedUpdate()
    {
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" || other.tag == "product") {
            Rigidbody rbp = other.GetComponent<Rigidbody>();
            Vector3 hehe = transform.up * -1f;
            hehe = hehe.normalized;
            hehe = hehe * 140f;
            rbp.AddForce(hehe, ForceMode.Acceleration);
            Rigidbody rbp6 = piano.GetComponent<Rigidbody>();
            rbp6.AddForce(new Vector3(0, ab, 0));
            Rigidbody rbp7 = piano1.GetComponent<Rigidbody>();
            rbp7.AddForce(new Vector3(0, ab, 0));
            Rigidbody rbp8 = piano2.GetComponent<Rigidbody>();
            rbp8.AddForce(new Vector3(0, ab, 0));
            rbp.AddForce(hehe, ForceMode.Acceleration);
            Rigidbody rbp3 = piano3.GetComponent<Rigidbody>();
            rbp3.AddForce(new Vector3(0, ab, 0));
            Rigidbody rbp4 = piano4.GetComponent<Rigidbody>();
            rbp4.AddForce(new Vector3(0, ab, 0));
            Rigidbody rbp5 = piano5.GetComponent<Rigidbody>();
            rbp5.AddForce(new Vector3(0, ab, 0));



        }
    }
}