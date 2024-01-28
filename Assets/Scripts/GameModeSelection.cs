using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameModeSelection : MonoBehaviour
{
    public void MirrorMode()
    {
        SceneManager.LoadScene(2);
    }
    public void AI()
    {
        SceneManager.LoadScene(3);
    }
}
