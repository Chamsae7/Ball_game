using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    public Text ui_score;

    public int score;

    private void Start()
    {
        score = 0;
    }

    public void PlusScore()
    {
        score++;
        ui_score.text = score.ToString("Score : 0");
    }
}
