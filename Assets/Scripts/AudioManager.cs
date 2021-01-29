using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource audioSource;

    [SerializeField]
    List<AudioClip> hurtNoises = new List<AudioClip>();
    [SerializeField]
    List<AudioClip> collectNoises = new List<AudioClip>();
    int clipToPlay;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayHurtSound()
    {
        PlayRandomSoundFromList(hurtNoises);
    }

    public void PlayCollectSound()
    {
        PlayRandomSoundFromList(collectNoises);
    }

    void PlayRandomSoundFromList(List<AudioClip> soundClipList)
    {
        clipToPlay = Random.Range(0, hurtNoises.Count);
        audioSource.PlayOneShot(hurtNoises[clipToPlay]);
    }
}
