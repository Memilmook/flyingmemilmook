using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverSound : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip[] soundClip;
    // Start is called before the first frame update
    void Start()
    {
        audio.PlayOneShot(soundClip[0]);
    }

}
