using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    void Start()
    {
        if (!audioSource) audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip audioClip)
    {
        if (!audioClip) return;
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
