using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRoomAudio : MonoBehaviour
{
    public AudioSource audioPlayer1;
    public AudioSource audioPlayer2;
    public AudioSource audioPlayer3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "AudioCollider1")
        {
            audioPlayer1.Play();
        }
        else if (other.gameObject.tag == "AudioCollider2")
        {
            audioPlayer2.Play();
        }
        else if (other.gameObject.tag == "AudioCollider3")
        {
            audioPlayer3.Play();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        audioPlayer1.Stop();
        audioPlayer2.Stop();
        audioPlayer3.Stop();
    }
}
