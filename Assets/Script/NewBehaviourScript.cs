using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject player;
    private Vector3 hehe;
    private Vector3 hehe1;
    private Vector3 hehe2;
    private Rigidbody rb;
    public float range = 4.0f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Use this for initialization
    void Start () {
    }


	// Update is called once per frame
	void FixedUpdate() {
        hehe = transform.position - player.transform.position;
        float distance = hehe.magnitude;
        if (distance < range)
        {
            hehe1 = Quaternion.Euler(0, 1.2f, 0) * hehe;
            transform.position = player.transform.position + hehe1;
        }
	
	}
}
