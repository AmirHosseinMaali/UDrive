using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    [SerializeField] TMP_Text TimeMinute;
    [SerializeField] TMP_Text TimeSecond;
    private void Update()
    {
        if (Save.LapTimesMinute <= 9)
        {
            TimeMinute.text = "0" + (Mathf.Round(Save.LapTimesMinute).ToString()) + ":";
        }
        else if (Save.LapTimesMinute > 9)
        {
            TimeMinute.text = (Mathf.Round(Save.LapTimesMinute).ToString()) + ":";
        }
        if (Save.LapTimesSeconds <= 9)
        {
            TimeMinute.text = "0" + (Mathf.Round(Save.LapTimesSeconds).ToString());
        }
        else if (Save.LapTimesSeconds > 9)
        {
            TimeMinute.text = (Mathf.Round(Save.LapTimesSeconds).ToString());
        }
    }
}
