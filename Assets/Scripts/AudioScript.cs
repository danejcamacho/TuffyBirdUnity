using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public float volume = 0.5f;
    public AudioClip jumpClip;
    public AudioClip hitClip;
    public AudioClip scoreClip;

    private AudioSource audioSource;
    void Start(){
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayJumpSound(){
        audioSource.PlayOneShot(jumpClip, volume);
    }

    public void PlayHitSound(){
        audioSource.PlayOneShot(hitClip, volume);
    }
    public void PlayScoreSound(){
        audioSource.PlayOneShot(scoreClip, volume);
    }
    
}
