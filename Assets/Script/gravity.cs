using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Rigidbody rbp = other.GetComponent<Rigidbody>();
            Vector3 hehe = transform.up * -1f;
            hehe = hehe.normalized;
            hehe = hehe * 80f;
            rbp.AddForce(hehe, ForceMode.Acceleration);
        }
    }
}
