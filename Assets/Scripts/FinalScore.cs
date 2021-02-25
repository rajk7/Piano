using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text mytext;
    public static int scorePoint = 0;
    void Start()
    {
        scorePoint = Score.scorePoint;
        mytext.text = scorePoint.ToString("0");
    }
    public void SaveScore()
    {

    }
}
