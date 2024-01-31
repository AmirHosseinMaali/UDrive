using System.Collections;
using UnityEngine;

public class ProgressTracker : MonoBehaviour
{
    public int CurrentWP = 0;
    public int ThisWPNumber;
    public int LastWPNumber;

    private void Update()
    {
        if (CurrentWP > LastWPNumber)
        {
            StartCoroutine(CheckDirection());
        }
        if (LastWPNumber > ThisWPNumber)
        {
            Save.WrongWay = false;
        }
        if (LastWPNumber < ThisWPNumber)
        {
            Save.WrongWay = true;
        }
    }
    IEnumerator CheckDirection()
    {
        yield return new WaitForSeconds(0.2f);
        ThisWPNumber = LastWPNumber;
    }

}
