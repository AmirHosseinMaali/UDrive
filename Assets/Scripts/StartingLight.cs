using System.Collections;
using UnityEngine;

public class StartingLight : MonoBehaviour
{
    public GameObject RightLightOff;
    public GameObject RightLightOn;
    public GameObject AmberLightOff;
    public GameObject AmberLightOn;
    public GameObject GreenLightOff;
    public GameObject GreenLightOn;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartingLights());
    }

    IEnumerator StartingLights()
    {
        yield return new WaitForSeconds(1);
        RightLightOff.SetActive(false);
        RightLightOn.SetActive(true);
        yield return new WaitForSeconds(1);
        RightLightOff.SetActive(true);
        RightLightOn.SetActive(false);
        AmberLightOff.SetActive(false);
        AmberLightOn.SetActive(true);
        yield return new WaitForSeconds(1);
        AmberLightOff.SetActive(true);
        AmberLightOn.SetActive(false);
        GreenLightOff.SetActive(false);
        GreenLightOn.SetActive(true);
        Save.RaceStart = true;

    }
}
