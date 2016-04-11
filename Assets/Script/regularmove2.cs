using UnityEngine;
using System.Collections;

public class regularmove2 : MonoBehaviour
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
        hehe = transform.position - player.transform.position;
        float distance = hehe.magnitude;
        if (distance < range)
        {
            hehe1 = Quaternion.Euler(0, 0.1f, 0) * hehe;
            transform.position = player.transform.position + hehe1;
        }


        var a = transform.position.y;
        if (a < -30)
        {
            rb.velocity = new Vector3 (0,0,0);
            rb.angularVelocity = new Vector3 (0,0,0);
            transform.position = transform.position + new Vector3(0, 50, 0);
        }
    }
}