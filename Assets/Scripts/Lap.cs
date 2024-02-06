using System.Collections;
using UnityEngine;

public class Lap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Save.WWTextReset = true;
            StartCoroutine(WrongWayReset());
            if (!Save.RaceOver)
            {

                if (Save.CheckPointPass)
                {

                    Save.LastLapTimesMinute = Save.LapTimesMinute;
                    Save.LastLapTimesSeconds = Save.LapTimesSeconds;
                    Save.LapNumber++;
                    Save.LapChange = true;
                    if (Save.LapNumber == 2)
                    {
                        Save.BestLapTimesMinute = Save.LastLapTimesMinute;
                        Save.BestLapTimesSeconds = Save.LastLapTimesSeconds;
                    }
                }
            }
        }
    }
    IEnumerator WrongWayReset()
    {
        yield return new WaitForSeconds(1.5f);
        Save.WWTextReset = false;
    }
}
