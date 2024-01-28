using UnityEngine;

public class AutoRotationHandler : MonoBehaviour
{
    [SerializeField] bool autorotateToPortrait = false;
    [SerializeField] bool autorotateToPortraitUpsideDown = false;
    [SerializeField] bool autorotateToLandscapeLeft = false;
    [SerializeField] bool autorotateToLandscapeRight = false;
    // Start is called before the first frame update
    void Start()
    {
        Screen.autorotateToPortrait = autorotateToPortrait;
        Screen.autorotateToPortraitUpsideDown = autorotateToPortraitUpsideDown;
        Screen.autorotateToLandscapeLeft = autorotateToLandscapeLeft;
        Screen.autorotateToLandscapeRight = autorotateToLandscapeRight;
    }
}
