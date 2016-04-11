using UnityEngine;
using System.Collections;

public class fallingdown : MonoBehaviour {

    public AudioClip[] audioClip;

    // Use this for initialization
    void Start () {
	
	}


    void OnTriggerEnter (Collider other)
    {
        if (other.transform.tag == "Player")
        {
            PlaySound(0);
        }
        if (other.transform.tag == "Player")
        {
            PlaySound(1);
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.transform.tag == "Player")
        {
            GetComponent<AudioSource>().mute = true;
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
