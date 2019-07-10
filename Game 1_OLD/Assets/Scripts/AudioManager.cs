using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public AudioClip colClip;
    public AudioSource source;

    private void Start()
    {
        source = gameObject.AddComponent<AudioSource>();
        source.clip = colClip;
    }
    public void PlayCollisionAudio()
    {
        source.Play();
    }
}
