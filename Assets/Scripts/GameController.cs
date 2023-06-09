using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public int totalScore;
    public static GameController instance;
    public Text scoreText;
    

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString(); 
    }
}
