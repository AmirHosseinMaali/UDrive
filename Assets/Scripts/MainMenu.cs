using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
//    [SerializeField] TMP_Text highScoreText;
//    [SerializeField] TMP_Text energyText;
//    [SerializeField] int maxEnergy;
    //[SerializeField] int energyRechargeDuration;

    //[SerializeField] AndroidNotifHandler notifHandler;

    //int energy;

    //const string EnergyKey = "Energy";
    //const string EnergyReadyKey = "EnergyReady";

    //private void Start()
    //{
    //    OnApplicationFocus(true);
    //}
    //private void OnApplicationFocus(bool focus)
    //{
    //    if (!focus) return;

    //    CancelInvoke();

    //    int highScore = PlayerPrefs.GetInt(Score.HighScoreKey, 0);
    //    highScoreText.text = $"High Score: {highScore}";

    //    energy = PlayerPrefs.GetInt(EnergyKey, maxEnergy);

    //    if (energy < maxEnergy)
    //    {
    //        string energyReadyString = PlayerPrefs.GetString(EnergyReadyKey, string.Empty);

    //        if (energyReadyString == string.Empty) { return; }

    //        DateTime energyReady = DateTime.Parse(energyReadyString);

    //        if (DateTime.Now > energyReady)
    //        {
    //            Debug.Log(DateTime.Now - energyReady);
    //            energy++;
    //            PlayerPrefs.SetInt(EnergyKey, energy);
    //        }
    //        else
    //        {
    //            Invoke(nameof(EnergyRecharged), (energyReady - DateTime.Now).Seconds);
    //        }
    //    }
    //    energyText.text = $"Play ({energy})";
    //}
    //private void EnergyRecharged()
    //{
    //    energy++;
    //    PlayerPrefs.SetInt(EnergyKey, energy);
    //    energyText.text = $"Play ({energy})";
    //}
    public void Play()
    {
        //if (energy < 1)
        //{
        //    return;
        //}
        //energy--;
        //PlayerPrefs.SetInt(EnergyKey, energy);
        //if (energy < maxEnergy)
        //{
        //    DateTime energyReady = DateTime.Now.AddMinutes(energyRechargeDuration);
        //    PlayerPrefs.SetString(EnergyReadyKey, energyReady.ToString());
        //    notifHandler.ScheduleNotification(energyReady);
        //}

        SceneManager.LoadScene(1);

    }
}
