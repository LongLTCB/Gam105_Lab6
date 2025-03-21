using UnityEngine;
using TMPro; // Nếu dùng TextMeshPro

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int score = 0;

    public TextMeshProUGUI scoreText; // Dùng cho TextMeshPro
    // public Text scoreText; // Dùng nếu UI Text cũ

    void Awake()
    {
        instance = this;
        if (scoreText == null)
        {
            Debug.LogError("⚠ ScoreText chưa được thiết lập trong Inspector!");
        }
    }

    public int Score  // Getter cho Score
    {
        get { return score; }
    }

    public void AddScore(int value)
    {
        score += value;
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
        else
        {
            Debug.LogError("⚠ ScoreText chưa được gán!");
        }
    }
}
