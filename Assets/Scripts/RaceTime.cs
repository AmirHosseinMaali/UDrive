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
}
