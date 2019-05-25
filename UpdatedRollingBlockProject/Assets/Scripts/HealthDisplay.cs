using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{

    private int score;
    public string scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = "ScoreText: " + score;
    }
}
