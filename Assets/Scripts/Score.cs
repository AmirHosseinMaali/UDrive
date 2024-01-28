using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] int scoreMultiplier = 10;

    public const string HighScoreKey = "HighScore";

    int score;
    float passedTime;

    // Update is called once per frame
    void Update()
    {
        ScoringSys(scoreMultiplier);
    }

    private void ScoringSys(int multiplier)
    {
        passedTime += Time.deltaTime;
        score = Mathf.FloorToInt(passedTime * multiplier);
        scoreText.text = score.ToString();
    }
    private void OnDestroy()
    {
        int currentHighScore = PlayerPrefs.GetInt(HighScoreKey, 0);
        if (score > currentHighScore)
        {
            PlayerPrefs.SetInt(HighScoreKey, score);
        }
    }
}
