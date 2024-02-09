using System.Collections;
using UnityEngine;

public class Penalty : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(PenaltyWait());
        }
    }
    IEnumerator PenaltyWait()
    {
        Save.PenaltySeconds = 2;
        yield return 0;
        Save.PenaltySeconds = 0;
    }
}
