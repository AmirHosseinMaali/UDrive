using UnityEngine;

public class RaceTime : MonoBehaviour
{
    public bool TimeTrial = true;
    public float GoldMinutes;
    public float GoldSeconds;
    public float SilverMinutes;
    public float SilverSeconds;
    public float BronzeMinutes;
    public float BronzeSeconds;

    private void Awake()
    {
        if (TimeTrial)
        {
            Save.TimeTrialMinG = GoldMinutes;
            Save.TimeTrialSecG = GoldSeconds;
            Save.TimeTrialMinS = SilverMinutes;
            Save.TimeTrialSecS = SilverSeconds;
            Save.TimeTrialMinB = BronzeMinutes;
            Save.TimeTrialSecB = BronzeSeconds;
        }
    }
    private void Update()
    {
        CalculateReward();
    }

    private void CalculateReward()
    {
        if (!Save.RaceOver)
        {
            return;
        }
        if (!TimeTrial)
        {
            return;
        }
        if (Save.RaceTimesMinute < GoldMinutes)
        {
            Debug.Log("Gold");
            Save.Gold = true;
        }
        else if (Save.RaceTimesMinute == GoldMinutes && Save.RaceTimesSeconds <= GoldSeconds)
        {
            Debug.Log("Gold");
            Save.Gold = true;
        }
        else if (Save.RaceTimesMinute < SilverMinutes)
        {
            Debug.Log("Silver");
            Save.Silver = true;
        }
        else if (Save.RaceTimesMinute == SilverMinutes && Save.RaceTimesSeconds <= SilverSeconds)
        {
            Debug.Log("Silver");
            Save.Silver = true;
        }
        else if (Save.RaceTimesMinute < BronzeMinutes)
        {
            Debug.Log("Bronze");
            Save.Bronze = true;
        }
        else if (Save.RaceTimesMinute == BronzeMinutes && Save.RaceTimesSeconds <= BronzeSeconds)
        {
            Debug.Log("Bronze");
            Save.Bronze = true;
        }
        else
        {
            Debug.Log("Fail");
            Save.Fail = true;
        }
    }
}
