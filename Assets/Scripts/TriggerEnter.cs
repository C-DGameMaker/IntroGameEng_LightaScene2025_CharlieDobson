using UnityEngine;
using UnityEngine.Playables;

public class TriggerEnter : MonoBehaviour
{
    public PlayableDirector timeline;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timeline.Play();
        }
    }

    
}
