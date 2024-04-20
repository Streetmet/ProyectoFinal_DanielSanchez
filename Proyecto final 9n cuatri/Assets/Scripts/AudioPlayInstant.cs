using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayInstant : MonoBehaviour
{

    public AudioClip clip;
    public AudioSource source;
    public float delay = 0.8f;
    
    void Start()
    {
        AudioDelay();
    }

    public void AudioDelay()
    {
        Invoke("AudioPlay", delay);
    }

    public void AudioPlay()
    {
        source.clip = clip;
        source.Play();

    }

}
