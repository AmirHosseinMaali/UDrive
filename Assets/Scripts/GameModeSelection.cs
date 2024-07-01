using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameModeSelection : MonoBehaviour
{
    public void TimeTrial()
    {
        SceneManager.LoadScene(2);
    }
    public void AI()
    {
        SceneManager.LoadScene(3);
    }
}
