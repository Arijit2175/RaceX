using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CarEngineSound : MonoBehaviour
{
    public Rigidbody carRb;

    public float minPitch = 0.8f;
    public float maxPitch = 1.6f;
    public float maxSpeed = 30f;

    private AudioSource engineSource;

    void Start()
    {
        engineSource = GetComponent<AudioSource>();
        engineSource.loop = true;
        engineSource.playOnAwake = true;
        engineSource.spatialBlend = 1f; 
        engineSource.Play();
    }

    void Update()
    {
        float speed = carRb.velocity.magnitude;
        float t = Mathf.Clamp01(speed / maxSpeed);
        engineSource.pitch = Mathf.Lerp(minPitch, maxPitch, t);
    }
}
