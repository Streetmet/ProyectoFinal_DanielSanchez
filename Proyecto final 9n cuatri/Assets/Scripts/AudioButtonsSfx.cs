using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButtonsSfx : MonoBehaviour
{
    public AudioSource buttonsSfx;
    public AudioClip buttonClip;

    public void ExecuteSound()
    {
        buttonsSfx.clip= buttonClip;
        buttonsSfx.Play();
    }
}
