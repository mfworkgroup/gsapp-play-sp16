using UnityEngine;
using System.Collections;

public class sound : MonoBehaviour {

    public AudioClip[] audioClip;

	// Use this for initialization
	void Start () {
	
	}
	
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "skyboxdesert" || other.transform.tag == "product")
        {
            PlaySound(0);
        }
        if (other.transform.tag == "pingpong")
        {
            PlaySound(1);
        }
        if (other.transform.tag == "sea")
        {
            PlaySound(2);
        }

    }



    void PlaySound(int clip)
    {
        GetComponent<AudioSource>().clip = audioClip[clip];
        GetComponent<AudioSource>().Play();
    }

	// Update is called once per frame
	void Update () {
	
	}
}
