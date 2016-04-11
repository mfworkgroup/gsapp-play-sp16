using UnityEngine;
using System.Collections;

public class RayCaster : MonoBehaviour
{

    public Transform prefab;
    public float scaleRange = 3.0f;
    public float forceMult = 20.0f;
    LineRenderer linerenderer;
    public Camera cam;
    public AudioClip[] audioClip;

    // Use this for initialization
    void Start()
    {
        linerenderer = gameObject.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // if mouse is clicked
        // input. GetMouseButtonDown() GetKeyDown()
        if (Input.GetMouseButtonDown(0))
        {
            // make a ray from our position to mouse position

            Ray rayOrigin = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            // draw the laser beam
            linerenderer.enabled = true;
            linerenderer.SetPosition(0, transform.position);
            linerenderer.SetPosition(1, rayOrigin.GetPoint(100));

            // make ray able to register what it hits
            if (Physics.Raycast(rayOrigin, out hit, 100000000.0f))
            {



                if (hit.rigidbody.tag == "product")
                {
                    hit.transform.localScale = new Vector3(30, 30, 30);
                    PlaySound(0);
                }
                if (hit.rigidbody.tag == "tree")
                {
                    hit.rigidbody.useGravity = true;
                    PlaySound(0);
                }
                if (hit.rigidbody.tag == "car")
                {
                    hit.rigidbody.AddForce(new Vector3(0, 180, 0));
                    PlaySound(0);
                }
                if (hit.rigidbody.tag == "animal")
                {
                    hit.rigidbody.transform.localScale = new Vector3(40, 40, 40);
                    PlaySound(0);
                }
            }
        }
        else {
            linerenderer.enabled = false;

        }
    }



    void PlaySound(int clip)
    {
        GetComponent<AudioSource>().clip = audioClip[clip];
        GetComponent<AudioSource>().Play();
    }
}
