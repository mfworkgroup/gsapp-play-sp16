using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour {
    private GameObject self;
    private Vector3 hehe;
    private Vector3 hehe1;
    private Vector3 hehe2;
    private Rigidbody rb;
    public float range = 4.0f;


    // Use this for initialization
    void Start () {
        self = this.gameObject;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerStay(Collider other)
    {
        Destroy(self);

    }
}
