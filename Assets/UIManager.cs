using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreTextUI;
    public TMP_InputField setScoreInputUI; 
    private int Score;  

    // Start is called before the first frame update
    void Awake()
    {
        Score = 0; 
    }   
   

    public void ScoreUp() 
    {
        Score += 15;
        if (Score > 1000000000)
            Score = 999999999;

        scoreTextUI.text = "Score: " + Score;
    }

    public void ScoreDown() 
    {
        Score -= 15;
        if (Score < 0)
            Score = 0; 

        scoreTextUI.text = "Score: " + Score;
    }

    public void ScoreReset() 
    {
        Score = 0;
        scoreTextUI.text = "Score: " + Score;
    }

    public void IncreaseSetNumberScore() 
    {
        Debug.Log(setScoreInputUI.text); 
        bool foundNewScore = int.TryParse(setScoreInputUI.text, out int newScore);
        if (foundNewScore)
        {
            Score += newScore;

            if (Score >= 1000000000)
                Score = 999999999;

            if (Score < 0)
                Score = 0;

            scoreTextUI.text = "Score: " + Score;
        } else
        {
            Debug.Log($"Failed to parse text [{setScoreInputUI.text}] as a number");
        }

        setScoreInputUI.text = ""; 
    }

}
