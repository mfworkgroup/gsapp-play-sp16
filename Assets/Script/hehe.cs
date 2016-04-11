using UnityEngine;
using System.Collections;

public class hehe : MonoBehaviour
{
    LineRenderer linerenderer;
    public Camera cam;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // make a ray from our position to mouse position

            Ray rayOrigin = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;



            if (Physics.Raycast(rayOrigin, out hit, 1000000.0f))
            {
                if (hit.rigidbody.tag == "product")
                {
                    hit.transform.localScale = new Vector3(5, 5, 2);

                }
                if (hit.rigidbody.tag == "tree")
                {
                    hit.rigidbody.useGravity = true;

                }

            }

        }
    }
}
