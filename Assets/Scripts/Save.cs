using UnityEngine;

public class Save : MonoBehaviour
{
    public static int LapNumber;
    public static int MaxLaps;
    public static int PlayerPosition;
    public static bool LapChange = false;
    public static bool CheckPointPass = true;
    public static float LapTimesMinute;
    public static float LapTimesSeconds;
    public static float RaceTimesMinute;
    public static float RaceTimesSeconds;
    public static float BestLapTimesMinute;
    public static float BestLapTimesSeconds;
    public static float LastLapTimesMinute;
    public static float LastLapTimesSeconds;
    public static float TimeTrialMinG;
    public static float TimeTrialMinS;
    public static float TimeTrialMinB;
    public static float TimeTrialSecG;
    public static float TimeTrialSecS;
    public static float TimeTrialSecB;
    public static float PenaltySeconds;
    public static bool WrongWay = false;
    public static bool WWTextReset = false;
    public static bool RaceStart = false;
    public static bool RaceOver = false;
    public static bool Gold = false;
    public static bool Silver = false;
    public static bool Bronze = false;
    public static bool Fail = false;

    // Update is called once per frame
    void Update()
    {
        if (!RaceOver)
        {

            if (LapChange && CheckPointPass)
            {
                CheckPointPass = false;
                LapChange = false;
                LapTimesMinute = 0;
                LapTimesSeconds = 0;
            }
            if (LapNumber >= 1)
            {
                LapTimesSeconds += Time.deltaTime + PenaltySeconds;
                RaceTimesSeconds += Time.deltaTime + PenaltySeconds;
            }

            if (LapTimesSeconds > 59)
            {
                LapTimesSeconds = 0;
                LapTimesMinute++;
            }
            if (RaceTimesSeconds > 59)
            {
                RaceTimesSeconds = 0;
                RaceTimesMinute++;
            }
        }
    }
}
