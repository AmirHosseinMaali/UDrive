using UnityEngine;

public class ProgressWaypoints : MonoBehaviour
{
    public int WPNumber;
    public int CarTracking = 0;
    public int Position = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CarTracking = other.GetComponent<ProgressTracker>().CurrentWP;
            if (CarTracking < WPNumber)
            {
                other.GetComponent<ProgressTracker>().CurrentWP = WPNumber;
                Position++;
                Save.PlayerPosition = Position;
            }
            if (CarTracking > WPNumber)
            {
                other.GetComponent<ProgressTracker>().LastWPNumber = WPNumber;
            }
        }
    }
}
