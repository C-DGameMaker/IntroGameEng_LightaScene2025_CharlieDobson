using UnityEngine;

public class ColliderScriptA : MonoBehaviour
{
    public AudioClip soundEffect; // Assign your sound effect in the Inspector
    private AudioSource audioSource;

    void Start()
    {
        // Get or add an AudioSource component
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = soundEffect;
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger has a specific tag (optional)

        audioSource.Play(); // Play the sound effect

    }
}
