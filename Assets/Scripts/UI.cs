using System.Collections;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TMP_Text LapNumberText;
    public TMP_Text TotalLapsText;
    public TMP_Text LapTimeMinutesText;
    public TMP_Text LapTimeSecondsText;
    public TMP_Text RaceTimeMinutesText;
    public TMP_Text RaceTimeSecondsText;
    public TMP_Text BestLapTimeMinutesText;
    public TMP_Text BestLapTimeSecondsText;
    public TMP_Text WrongWayT;
    public GameObject NewRecord;
    public GameObject WrongWay;
    public int TotalLaps = 3;
    // Start is called before the first frame update
    void Start()
    {
        LapNumberText.text = "0";
        TotalLapsText.text = "/" + TotalLaps.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        LapNumberText.text = Save.LapNumber.ToString();
        LapTimer();
        RaceTimer();
        BestLapTimer();
        WrongWayCheck();
    }

    private void BestLapTimer()
    {
        if (Save.LastLapTimesMinute == Save.BestLapTimesMinute)
        {
            if (Save.LastLapTimesSeconds < Save.BestLapTimesSeconds)
            {
                Save.BestLapTimesSeconds = Save.LastLapTimesSeconds;

                StartCoroutine(LateCall(2));
            }
        }
        else if (Save.LastLapTimesMinute < Save.BestLapTimesMinute)
        {
            Save.BestLapTimesMinute = Save.LastLapTimesMinute;
            Save.BestLapTimesSeconds = Save.LastLapTimesSeconds;

            StartCoroutine(LateCall(2));

        }
        if (Save.BestLapTimesMinute <= 9)
        {
            BestLapTimeMinutesText.text = "0" + (Mathf.Round(Save.BestLapTimesMinute).ToString()) + ":";
        }
        else if (Save.BestLapTimesMinute > 9)
        {
            BestLapTimeMinutesText.text = (Mathf.Round(Save.BestLapTimesMinute).ToString()) + ":";
        }
        if (Save.BestLapTimesSeconds <= 9)
        {
            BestLapTimeSecondsText.text = "0" + (Mathf.Round(Save.BestLapTimesSeconds).ToString());
        }
        else if (Save.BestLapTimesSeconds > 9)
        {
            BestLapTimeSecondsText.text = (Mathf.Round(Save.BestLapTimesSeconds).ToString());
        }
    }

    private void LapTimer()
    {
        if (Save.LapTimesMinute <= 9)
        {
            LapTimeMinutesText.text = "0" + (Mathf.Round(Save.LapTimesMinute).ToString()) + ":";
        }
        else if (Save.LapTimesMinute > 9)
        {
            LapTimeMinutesText.text = (Mathf.Round(Save.LapTimesMinute).ToString()) + ":";
        }
        if (Save.LapTimesSeconds <= 9)
        {
            LapTimeSecondsText.text = "0" + (Mathf.Round(Save.LapTimesSeconds).ToString());
        }
        else if (Save.LapTimesSeconds > 9)
        {
            LapTimeSecondsText.text = (Mathf.Round(Save.LapTimesSeconds).ToString());
        }
    }
    private void RaceTimer()
    {
        if (Save.RaceTimesMinute <= 9)
        {
            RaceTimeMinutesText.text = "0" + (Mathf.Round(Save.RaceTimesMinute).ToString()) + ":";
        }
        else if (Save.RaceTimesMinute > 9)
        {
            RaceTimeMinutesText.text = (Mathf.Round(Save.RaceTimesMinute).ToString()) + ":";
        }
        if (Save.RaceTimesSeconds <= 9)
        {
            RaceTimeSecondsText.text = "0" + (Mathf.Round(Save.RaceTimesSeconds).ToString());
        }
        else if (Save.RaceTimesSeconds > 9)
        {
            RaceTimeSecondsText.text = (Mathf.Round(Save.RaceTimesSeconds).ToString());
        }
    }


    IEnumerator LateCall(float seconds)
    {
        NewRecord.SetActive(true);

        yield return new WaitForSeconds(seconds);

        NewRecord.SetActive(false);
    }
    private void WrongWayCheck()
    {
        if (Save.WrongWay)
        {
            WrongWay.SetActive(true);
        }
        else
        {
            WrongWay.SetActive(false);
        }
        if (Save.WWTextReset == false)
        {
            WrongWayT.text = "WRONG WAY!";
        }
        if (Save.WWTextReset == true)
        {
            WrongWayT.text = " ";
        }

    }

}
