using UnityEngine;
using UnityEngine.Playables;

public class TriggerMultipleTimelines : MonoBehaviour
{
    public PlayableDirector timeline1;
    public PlayableDirector timeline2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timeline1.Stop();
            timeline2.Play();
        }
    }
}
