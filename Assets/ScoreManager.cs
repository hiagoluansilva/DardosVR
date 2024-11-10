using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    
    public Text scoreText;

    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Teste Placar: " + score.ToString();
    }

    public void AddScore()
    {
        score += 1;
        scoreText.text = "Teste Placar: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
