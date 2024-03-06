using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioClip pong;
    AudioSource audiosource;
    float vol = 0.3f;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AudioPong()
    {
        audiosource.PlayOneShot(pong, vol);
    }
}
