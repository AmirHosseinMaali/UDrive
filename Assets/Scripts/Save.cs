using UnityEngine;

public class Save : MonoBehaviour
{
    public static int LapNumber;
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
    public static bool WrongWay = false;

    // Update is called once per frame
    void Update()
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
            LapTimesSeconds += Time.deltaTime;
            RaceTimesSeconds += Time.deltaTime;
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
