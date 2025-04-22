using System.Collections;
using UnityEngine;

public class DreamCarTrack : MonoBehaviour
{
    public GameObject TheMarker;
    public GameObject[] Markers; 

    public int MarkTracker=0;

    void Update()
    {
        if (MarkTracker >= 0 && MarkTracker < Markers.Length)
        {
            TheMarker.transform.position = Markers[MarkTracker].transform.position;
        }
    }
    IEnumerator OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "DreamCar")
        {
            this.GetComponent<BoxCollider>().enabled = false;

            MarkTracker++;
            if (MarkTracker >= Markers.Length)
            {
                MarkTracker = 0;
            }

            yield return new WaitForSeconds(1.5f);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
