using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int ScorePerTime = 400;
    public int currentScore = 0;
    public GameObject GOScore;

    TextMeshProUGUI text, gameOverScoreText;

    float _timeInterval = 1f;
    float _timeSinceLastUpdate = 0;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        gameOverScoreText = GOScore.GetComponent<TextMeshProUGUI>();
        currentScore = 0;
        Show();
    }

    void Update()
    {
        if (Time.time > _timeSinceLastUpdate+_timeInterval)
        {
            _timeSinceLastUpdate = Time.time;

            UpdateScore(ScorePerTime);
        }
    }

    public void UpdateScore(int score)
    {
        currentScore += score;
        text.text = currentScore.ToString("D9");
        gameOverScoreText.text = currentScore.ToString();
    }

    public void Hide()
    {
        text.enabled = false;
    }

    public void Show()
    {
        text.enabled = true;
    }

}
