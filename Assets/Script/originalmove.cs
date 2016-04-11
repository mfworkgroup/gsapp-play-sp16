using UnityEngine;
using System.Collections;

public class originalmove : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;
    private Vector3 offset1;

    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
        offset1 = offset.normalized;
        transform.position = player.transform.position + offset1 * 24;


	
	}
	
	// Update is called once per frame
	void Update () {
        offset = transform.position - player.transform.position;
        offset1 = offset.normalized;
        transform.position = player.transform.position + offset1 * 24;


    }
}
