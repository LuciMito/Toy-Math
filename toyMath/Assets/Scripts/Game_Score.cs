using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Score : MonoBehaviour
{

    public int score;
    private int totalScore;
    public static Game_Score instance;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        totalScore = PlayerPrefs.GetInt("score");
        Debug.Log(PlayerPrefs.GetInt("score"));
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = PlayerPrefs.GetInt("score").ToString();
    }

    public void UpdateScoreText()
    {
        scoreText.text = PlayerPrefs.GetInt("score").ToString();
        totalScore += score;
        PlayerPrefs.SetInt("score", totalScore);
    }

}
