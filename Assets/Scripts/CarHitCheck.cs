using UnityEngine;
using UnityEngine.SceneManagement;

public class CarHitCheck : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
