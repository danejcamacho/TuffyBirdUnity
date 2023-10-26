using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private TMPro.TextMeshProUGUI scoreText;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = gameObject.GetComponent<TMPro.TextMeshProUGUI>();
    }

    public void UpdateScore()
    {
        score += 1;
        scoreText.text = FormatScore(score);
    }

    string FormatScore(int val) {
        return "Score: " + val;
    }

}
