using UnityEngine;
using System.Collections;

public class turn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "fish")
        {
            other.transform.position = other.transform.position + new Vector3(0, 0, -270);
        }
    }
}
