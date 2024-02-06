using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public GameObject FinishPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Save.CheckPointPass = true;
            if (Save.LapNumber==Save.MaxLaps)
            {
                FinishPoint.SetActive(true);
            }
        }
    }
}
