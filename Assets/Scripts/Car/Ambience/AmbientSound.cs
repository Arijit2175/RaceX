using UnityEngine;

public class AmbientSound : MonoBehaviour
{
    public AudioClip ambienceClip;

    private AudioSource source;

    void Start()
    {
        source = gameObject.AddComponent<AudioSource>();
        source.clip = ambienceClip;
        source.loop = true;
        source.volume = 0.5f;
        source.spatialBlend = 0f; 
        source.Play();
    }
}
