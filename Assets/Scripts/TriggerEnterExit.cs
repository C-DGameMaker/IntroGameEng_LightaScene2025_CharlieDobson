using UnityEngine;
using UnityEngine.Playables;

public class TriggerEnterExit : MonoBehaviour
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
