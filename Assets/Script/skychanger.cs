using UnityEngine;
using System.Collections;

public class skychanger : MonoBehaviour {

    public Material defsky;
    public Material space;
    public Material desert;
    public Material sea;
    public Material home;

    // Use this for initialization
    void Start () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "skyboxspace")
        {
            RenderSettings.skybox = space;
        }
        if (other.transform.tag == "skyboxdesert")
        {
            RenderSettings.skybox = desert;
        }
        if (other.transform.tag == "sea")
        {
            RenderSettings.skybox = sea;
        }
        if (other.transform.tag == "home")
        {
            RenderSettings.skybox = home;
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "skyboxspace" || other.transform.tag == "skyboxdesert" || other.transform.tag == "sea" || other.transform.tag == "home")
        {
            RenderSettings.skybox = defsky;
        }
    }


    // Update is called once per frame
    void Update () {
	
	}
}

