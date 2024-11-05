using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController instance;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    public void PlayThisSound(string clipName, float volumMutilplier)
    {
        
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.volume *= volumMutilplier;
        audioSource.PlayOneShot((AudioClip)Resources.Load("Sounds/" + clipName, typeof(AudioClip)));
     }
}
