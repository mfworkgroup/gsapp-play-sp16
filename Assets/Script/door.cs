using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
    public GameObject hehe;
    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            offset = hehe.transform.position - other.transform.position;
            other.transform.position = other.transform.position + offset;

        }
    }
}
