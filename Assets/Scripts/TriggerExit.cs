using UnityEngine;
using UnityEngine.Playables;

public class TriggerExit : MonoBehaviour
{
    public PlayableDirector timeline;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timeline.Stop();
        }
    }
}
