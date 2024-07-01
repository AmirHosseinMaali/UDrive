using System.Collections;
using UnityEngine;

public class StartingLight : MonoBehaviour
{
    public GameObject RedLightOff;
    public GameObject RedLightOn;
    public GameObject AmberLightOff;
    public GameObject AmberLightOn;
    public GameObject GreenLightOff;
    public GameObject GreenLightOn;
    public AudioSource Sound1;
    public AudioSource Sound2;
    public GameObject Go;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartingLights());
    }

    IEnumerator StartingLights()
    {
        yield return new WaitForSeconds(1);
        RedLightOff.SetActive(false);
        RedLightOn.SetActive(true);
        Sound1.Play();
        yield return new WaitForSeconds(1);
        RedLightOff.SetActive(true);
        RedLightOn.SetActive(false);
        Sound1.Play();
        AmberLightOff.SetActive(false);
        AmberLightOn.SetActive(true);
        yield return new WaitForSeconds(1);
        AmberLightOff.SetActive(true);
        AmberLightOn.SetActive(false);
        Sound2.Play();
        GreenLightOff.SetActive(false);
        GreenLightOn.SetActive(true);
        yield return new WaitForSeconds(.1f);
        Save.RaceStart = true;
        Go.SetActive(true);
        yield return new WaitForSeconds(2);
        Go.SetActive(false);
        GreenLightOff.SetActive(true);
        GreenLightOn.SetActive(false);
    }
}
