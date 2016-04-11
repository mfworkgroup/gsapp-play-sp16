using UnityEngine;
using System.Collections;

public class regularmove4 : MonoBehaviour
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


        r = new Vector3(0, 0, -10);
        rb.AddForce(r);
        var a = transform.position.z;
        if (a < 50)
        {
            transform.position = transform.position + new Vector3(0, 0, 290);
            rb.velocity = new Vector3(0, 0, 0);
            rb.angularVelocity = new Vector3(0, 0, 0);
            rb.Sleep();
        }
    }
}
