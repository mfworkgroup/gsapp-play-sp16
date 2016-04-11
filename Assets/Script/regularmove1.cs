using UnityEngine;
using System.Collections;

public class regularmove1 : MonoBehaviour
{

	public GameObject p1;
	public GameObject p2;

    void Awake()
    {
    }
    // Use this for initialization
    void Start()
    {
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        var a = transform.position.z;
		if (a > p1.transform.position.z)
        {
			transform.position = transform.position + new Vector3 (0, 0, -250);
        }
		if (a < p2.transform.position.z)
        {
			transform.position = transform.position + new Vector3 (0, 0, 250);
        }
    }
}
