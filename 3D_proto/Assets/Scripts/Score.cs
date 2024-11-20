using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int _score;

    private void Awake()
    {
       DrawScore();
    }

    public void AddScore(int value)
    {
        _score += value;
        DrawScore();
    }
    private void DrawScore()
    {
        scoreText.text = $@"Score: {_score}";
    }
}
