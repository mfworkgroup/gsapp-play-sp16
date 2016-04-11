using UnityEngine;
using System.Collections;

public class regularmove3 : MonoBehaviour
{

    public GameObject player;
    private Vector3 hehe;
    private Vector3 hehe1;
    private Vector3 hehe2;
    private Vector3 r;
    private Rigidbody rb;
    public float range = 4.0f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Use this for initialization
    void Start()
    {
    }


    // Update is called once per frame
    void FixedUpdate()
    {


        r = new Vector3(0, 0, 100);
        rb.AddForce(r);

    }
}