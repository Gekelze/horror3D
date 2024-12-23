using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI tmpScore;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdateScore()
    {    
        tmpScore.text = "Score: " + score;
    }
    public void AddScore()
    {
        score++;
        UpdateScore();
    }
}
