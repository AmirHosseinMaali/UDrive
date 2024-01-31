using UnityEngine;

public class ProgressWaypoints : MonoBehaviour
{
    public int WPNumber;
    public int CarTracking = 0;
    public bool PenaltyOption = false;
    public int PenaltyWayPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CarTracking = other.GetComponent<ProgressTracker>().CurrentWP;
            if (CarTracking < WPNumber)
            {
                other.GetComponent<ProgressTracker>().CurrentWP = WPNumber;
            }
            if (CarTracking > WPNumber)
            {
                other.GetComponent<ProgressTracker>().LastWPNumber = WPNumber;
            }
            if (PenaltyOption)
            {
                if (CarTracking < PenaltyWayPoint)
                {
                    Debug.Log("Penalty");
                }
            }
        }
    }
}
